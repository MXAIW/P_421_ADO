using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Academy.Models
{
    class Item
    {
        internal int id;
        internal string name;
        internal string nameItem;

        public Item(int id, string name, string nameItem)
        {
            this.id = id;
            this.name = name;
            this.nameItem = nameItem;
        }

        public Item(object[] objects, string nameItem)
        {
            this.id = (int)objects[0];
            this.name = objects[1].ToString();
            this.nameItem = nameItem;
        }

        public Item(Item other)
        {
            this.id = other.id;
            this.name = other.name;
            this.nameItem = other.nameItem;
        }

        public virtual string GetNames()
        {
            return $"{nameItem}_id,{nameItem}_name";
        }

        public virtual string Getvalues()
        {
            return $"N'{name}'";
        }

        public virtual string GetUpdateExpression()
        {
            return $"{nameItem}_name=N'{name}',";
        }
    }
}
