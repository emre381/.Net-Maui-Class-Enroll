using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2.Models
{

    public class StudentData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
    }
}
