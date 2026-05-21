using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    class Query
    {
        string fields;
        string tables;
        string conditions;
        public Query(string fields, string tables, string conditions = "")
        {
            this.fields = fields;
            this.tables = tables;
            this.conditions = conditions;
        }
        public override string ToString()
        {
            string cmd = $"SELECT {fields} FROM {tables} ";
            if (conditions != "") cmd += $" WHERE {conditions}";
            return cmd;
        }
    }
}
