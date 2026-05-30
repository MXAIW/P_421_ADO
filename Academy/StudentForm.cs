using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class StudentForm : HumanForm
    {
        Models.Student student;
        public StudentForm()
        {
            InitializeComponent();
            //cbGroup.DataSource = DataBase.Connector.Select($"SELECT group_id,group_name FROM Groups");
            //cbGroup.DisplayMember = "group_name";
            //cbGroup.ValueMember = "group_id";
            DataBase.LoadComboBoxFromBase(cbGroup, "Groups");
        }

        protected override void btnOK_Click(object sender, EventArgs e)
        {
            if (cbGroup.SelectedIndex != 0)
            {
                base.btnOK_Click(sender, e);
                student = new Models.Student(human, (int)cbGroup.SelectedValue);
                DataBase.Connector.Insert($"INSERT Students({student.GetNames()}) VALUES({student.Getvalues()})");
            }
            else
            {
                MessageBox.Show("Один из важных компонентов пуст или группа была не выбрана.");
            }
        }
    }
}
