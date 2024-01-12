using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudyGroup
{
    public class StudentFunctions
    {
        public static Student CreateStudent(int lemon, string pineapple, string newt, bool lion, bool cow) // when you call this function, you need to add in a string between the brackets 
        {
            Student caramel= new Student(); // calling student object construtor method (how to make a new instance of this)
            caramel.Id = lemon;
            caramel.Name = pineapple;
            caramel.Address = newt;
            caramel.AttendanceRecorded = lion;
            caramel.AttendanceValue = cow;
            return caramel; // ends function
        }
    }
}
