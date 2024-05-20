using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2.Models
{
   
    public class CourseData
    {
        [PrimaryKey, AutoIncrement]
        public int CourseCode { get; set; }

        public string CourseName { get; set; } = string.Empty;
    }
}
