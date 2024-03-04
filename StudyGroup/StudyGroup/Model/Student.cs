using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroup.Model
{
    public class Student
    {
        public Student()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool AttendanceRecorded { get; set; }
        public bool AttendanceValue { get; set; }
    }
}
