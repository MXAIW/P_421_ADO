using Academy.Models;
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
    public partial class ItemForm : Form
    {
        internal Models.Item item;
        public ItemForm()
        {
            InitializeComponent();
        }

        protected virtual void Compress(string itemName)
        {
            //Упаковывает пользовательские данные из формы в объект класса "Item":
            item = new Models.Item
                (
                Convert.ToInt32(labelID.Text == "" ? "0" : labelID.Text.Split(':').Last()),
                tbName.Text,
                itemName
                );
        }

        protected virtual void Exctract()
        {
            this.labelID.Text = $"ID:{item.id}";
            this.tbName.Text = item.name;
        }

        protected virtual void btnOK_Click(object sender, EventArgs e, string itemName)
        {
            if (tbName.Text != "")
            {
                Compress(itemName);
                MessageBox.Show($"Всё получилось");
            }
            else
            {
                MessageBox.Show($"Один из важных компонентов пуст.");
            }
        }
    }
}
