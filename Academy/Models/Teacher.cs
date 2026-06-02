using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.Models
{
    class Teacher : Human
    {
        string work_since;
        public Teacher
            (
            int id,
            string last_name, string first_name, string middle_name,
            string birth_date, string email, string phone, Image photo,
            string work_since
            ) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
        {
            this.work_since = work_since;
        }

        public Teacher(Human human, string work_since) : base(human)
        {
            this.work_since = work_since;
        }

        public override string GetNames()
        {
            return base.GetNames() + ",work_since,teacher_id";
        }
        public override string Getvalues()
        {
            return base.Getvalues() + $",N'{work_since}',N'10'";
        }
    }
}
