using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Configuration;
using DBtools;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		DataGridView[] tables;
		Query[] queries =
		{
			new Query
			(
                "stud_id,FORMATMESSAGE(N'%s %s %s',last_name,first_name,middle_name)AS N'Студент',birth_date,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
			),
			new Query
			(
				"group_id,group_name,direction_name,start_date,start_time,learning_days",
				"Groups,Directions",
				"direction=direction_id"
			),
			new Query("*", "Directions"),
            new Query("*", "Disciplines"),
            new Query("*", "Teachers"),
        };
		public MainForm()
		{
			AllocConsole();
			InitializeComponent();
			tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
			//dgvStudents.DataSource = connector.Load("SELECT * FROM Students");
			/*dgvStudents.DataSource = connector.Load
				(
				"stud_id,last_name,first_name,middle_name,birth_date,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
				);*/
			//toolStripStatusLabel.Text = $"Количество записей: {dgvStudents.RowCount - 1}";
			
			tabControl.SelectedIndex = 0;
            tabControl_SelectedIndexChanged(tabControl, null);
			/////////////////////////////

			//cbGroupsDirection.SelectedIndex = 0;
        }
		[DllImport("kernel32.dll")]
		public static extern bool AllocConsole();
		void LoadComboBoxFromBase(ComboBox comboBox, string table, string condition = "")
        {
            string column = table.Substring(0, table.Length - 1).ToLower();
			string cmd = $"SELECT {column}_id,{column}_name FROM {table}";
			if (condition != "")
				cmd += $" WHERE {condition}";
            DataTable dt = connector.Load(cmd);
            DataRow rowDefault = dt.NewRow();
            rowDefault[0] = 0;
            rowDefault[1] = "Все";
            dt.Rows.InsertAt(rowDefault, 0);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = $"{column}_name";
            comboBox.ValueMember = $"{column}_id";
			comboBox.SelectedIndex = 0;
        }

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int i = tabControl.SelectedIndex;
			tables[i].DataSource = connector.Load(queries[i].ToString());
            //tables[i].DataSource = connector.Select("*", $"{tabControl.SelectedTab.Text}");
            toolStripStatusLabel.Text = $"Количество записей: {tables[i].RowCount - 1}";
			//for (int c = 0; c < tables[i].ColumnCount-1; c++) tables[i].Columns[c].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
			tables[i].Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tables[i].Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LoadComboBoxFromBase(cbGroupsDirection, "Directions");
            LoadComboBoxFromBase(cbStudentsGroup, "Groups");
            LoadComboBoxFromBase(cbStudentsDiwection, "Directions");
        }


        private void cbGroupsDirection_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tables[1].DataSource = connector.Load
				(
				queries[1].ToString() + 
				(cbGroupsDirection.SelectedIndex == 0 ? "" : $" AND direction={cbGroupsDirection.SelectedValue}")
				);
            //Console.WriteLine($"SelectedIndex:{cbGroupsDirection.SelectedIndex}");
            //Console.WriteLine($"SelectedItem:{cbGroupsDirection.SelectedItem}");
            //Console.WriteLine($"SelectedText:{cbGroupsDirection.SelectedText}");
            //Console.WriteLine($"SelectedValue:{cbGroupsDirection.SelectedValue}");
            toolStripStatusLabel.Text = $"Количество записей: {tables[1].RowCount - 1}";
        }

        private void cbStudentsGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
			if (cbStudentsGroup.SelectedIndex == 0)
				cbStudentsDiwection_SelectionChangeCommitted(cbStudentsDiwection, null);
			else
				tables[0].DataSource = connector.Load
				(
					queries[0].ToString() +
					(cbStudentsGroup.SelectedIndex == 0 ? "" : $" AND [group]={cbStudentsGroup.SelectedValue}")
				);
			toolStripStatusLabel.Text = $"Количество записей: {tables[0].RowCount - 1}";
        }

		private void cbStudentsDiwection_SelectionChangeCommitted(object sender, EventArgs e)
		{
			tables[0].DataSource = connector.Load
			(
				queries[0] +
				(cbStudentsDiwection.SelectedIndex == 0 ? "" : $" AND direction={cbStudentsDiwection.SelectedValue}")
			);
			LoadComboBoxFromBase
			(
				cbStudentsGroup, 
				"Groups", 
				(cbStudentsDiwection.SelectedIndex == 0 ? "" : $" direction={cbStudentsDiwection.SelectedValue}")
			);
            toolStripStatusLabel.Text = $"Количество записей: {tables[0].RowCount - 1}";
        }


        private void tbAddStudents_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbAddStudents.Text != "")
            {
                string[] strings = tbAddStudents.Text.Split(' ');

                string firstName = "";
                string middleName = "";
                string lastName = "";
                string birthDate = "";
                string group = "";

                for (int i = 0; i < strings.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            lastName = strings[i];
                            break;
                        case 1:
                            firstName = strings[i];
                            break;
                        case 2:
                            if (strings[2].ToString() != "-")
                                middleName = strings[i];
                            else
                                middleName = "";
                            break;
                        case 3:
                            birthDate = strings[i];
                            break;
                        case 4:
                            if (strings[4].ToString() != "-")
                                group = strings[i];
                            else
                                group = "";
                            break;
                    }
                }
                //try
                //{
                    Console.WriteLine("Попытка конвертировать дату");
                    DateTime dtBirthDate = DateTime.Parse(birthDate);
                    string groupId = "";
                    if (group != "")
                    {
                        Console.WriteLine($"Поиск группы {group}");
                        DataTable tb = connector.Load("group_id", "Groups", $"group_name = '{group}'");
                        if (tb.Rows.Count == 0)
                        {
                            MessageBox.Show("Не удалось найти группу");
                            Console.WriteLine($"Не удалось найти группу {group}");
                        }
                        groupId = tb.Rows[0]["group_id"].ToString();
                        
                        
                        connector.Insert
                        (
                            $"INSERT INTO Students " +
                            $"(last_name, first_name, middle_name, birth_date, [group]) " +
                            $"VALUES ('{lastName}', '{firstName}', '{middleName}', '{dtBirthDate}', '{groupId}') "
                        );
                    }
                    else
                    {

                        connector.Insert
                        (
                            $"INSERT INTO Students " +
                            $"(last_name, first_name, middle_name, birth_date) " +
                            $"VALUES ('{lastName}', '{firstName}', '{middleName}', '{dtBirthDate}') "
                        );
                    }
                    Console.WriteLine("Попытка вставить");
                    /*connector.Insert
                    (
                        $"INSERT INTO Students " +
                        (group != "" ? $"(last_name, first_name, middle_name, birth_date, group_id) " : $"(last_name, first_name, middle_name, birth_date) ") +
                        (group != "" ? $"VALUES ('{lastName}', '{firstName}', '{middleName}', '{dtBirthDate}', '{groupId}') " : $"VALUES ('{lastName}', '{firstName}', '{middleName}', '{dtBirthDate}') ")
                    );*/
                //connector.Insert("Students", "(last_name, first_name, middle_name, birth_date, group)", tbAddStudents.Text);
                tbAddStudents.Clear();
                    MessageBox.Show($"Всё получилось!\n Имя: {firstName}\n Фамилия: {lastName}\n Очество: {middleName}\n Дата Рождения: {birthDate}\n Группа: {group}");
                /*}
                catch
                {
                    MessageBox.Show($"Не удалось добавить пользователя\nВозможно, дело в форматирование. Пиши без запятых, разделяя значения пробелами. Если очество или группа отсуствует, то напишите \"-\". Пример:\n Иванович Иван Иванов 01.01.1999 П_421\n Вы написали: \n Имя: {firstName}\n Фамилия: {lastName}\n Очество: {middleName}\n Дата Рождения: {birthDate}\n Группа: {group}");
                }*/

                tbAddStudents.Clear();
            }
            /*
            else
            {
                tbAddStudents.Clear();
                tbAddStudents.Text = "Добавить студента (ФИО, дата рождения, группа, без запятых через пробел)";
            }*/
        }

        private void tbAddTeacher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbAddTeacher.Text != "")
            {
                string[] strings = tbAddTeacher.Text.Split(' ');

                string firstName = "";
                string middleName = "";
                string lastName = "";
                string birthDate = "";

                for (int i = 0; i < strings.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            lastName = strings[i];
                            break;
                        case 1:
                            firstName = strings[i];
                            break;
                        case 2:
                            if (strings[2].ToString() != "-")
                                middleName = strings[i];
                            else
                                middleName = "";
                            break;
                        case 3:
                            birthDate = strings[i];
                            break;
                    }
                }
                //try
                //{
                Console.WriteLine("Попытка конвертировать дату");
                DateTime dtBirthDate = DateTime.Parse(birthDate);

                connector.Insert
                (
                        $"INSERT INTO Teachers " +
                        $"(last_name, first_name, middle_name, birth_date) " +
                        $"VALUES ('{lastName}', '{firstName}', '{middleName}', '{dtBirthDate}') "
                );
                Console.WriteLine("Попытка вставить");
                tbAddStudents.Clear();
                MessageBox.Show($"Всё получилось!\n Имя: {firstName}\n Фамилия: {lastName}\n Очество: {middleName}\n Дата Рождения: {birthDate}");
                /*}
                catch
                {
                    MessageBox.Show($"Не удалось добавить пользователя\nВозможно, дело в форматирование. Пиши без запятых, разделяя значения пробелами. Если очество или группа отсуствует, то напишите \"-\". Пример:\n Иванович Иван Иванов 01.01.1999 П_421\n Вы написали: \n Имя: {firstName}\n Фамилия: {lastName}\n Очество: {middleName}\n Дата Рождения: {birthDate}\n Группа: {group}");
                }*/

                tbAddStudents.Clear();
            }
            /*
            else
            {
                tbAddStudents.Clear();
                tbAddStudents.Text = "Добавить студента (ФИО, дата рождения, группа, без запятых через пробел)";
            }*/
        }
    }
}
