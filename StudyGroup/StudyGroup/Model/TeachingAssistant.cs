using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroup.Model
{
    public class TeachingAssistant : Student
    {
        public string CollegeEmailAddress { get; set; }
        public bool TookAttendance { get; set; }
    }
}
