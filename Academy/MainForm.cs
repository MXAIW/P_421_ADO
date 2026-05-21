using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using DBtools;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		public MainForm()
		{
			InitializeComponent();
			connector = new Connector(ConfigurationManager.ConnectionStrings["P_421_Import"].ConnectionString);
            //dgvStudents.DataSource = connector.Load("SELECT * FROM Students");
            dgvStudents.DataSource = connector.Load
				(
				"stud_id,last_name,first_name,middle_name,birth_date,group_name,direction_name",
				"Students,Groups,Directions",
				"[group]=group_id AND direction=direction_id"
				);
            dgvGroups.DataSource = connector.Load
                (
                "group_id,group_name,direction_name,start_date,start_time,learning_days",
                "Groups,Directions,Students",
                "[group]=group_id AND direction=direction_id" +
                " GROUP BY group_id,group_name,direction_name,start_date,start_time,learning_days"
                );
            dgvDirections.DataSource = connector.Load
                (
                "direction_id,direction_name",
                "Directions",
                ""
                );
            dgvDisciplines.DataSource = connector.Load
                (
                "discipline_id,discipline_name,number_of_lessons",
                "Disciplines",
                ""
                );
            dgvTeacher.DataSource = connector.Load
                (
                "teacher_id,last_name,first_name,middle_name,birth_date,email,phone,photo,work_since,rate",
                "Teachers",
                ""
                );
            toolStripStatusLabel.Text = $"Количество записей: {dgvStudents.RowCount - 1}";
        }
    }
}
