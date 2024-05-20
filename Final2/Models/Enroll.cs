using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2.Models
{
    public class Enroll
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public int StudentID { get; set; }
        public string Name { get; set; } = "";
        public string Department { get; set; } = string.Empty;

        public int CourseCode { get; set; }
        public string CourseName { get; set; } = "";
    }
}
