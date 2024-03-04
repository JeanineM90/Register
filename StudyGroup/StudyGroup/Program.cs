using StudyGroup; // this is the namespace
using StudyGroup.Controller;
using StudyGroup.Model;
using StudyGroup.View;
using System.Text.Json;
//using System.Text.Json;

var students = new List<Student> //Impicit: variable strawberry, explict would be List<Student> strawberry
    // variable declaration = variable instantiation

    { // start of the list- what students are going to be here  
        new Student (), //will instantiate with minimum values 
        new Student // will instantiate with these specific values - property assignment 
        {
            Id = 1,
            Name = "Lisa",
            Address =  "742 Evergreen Terrace",
            AttendanceRecorded = true,
            AttendanceValue= true
        },

        new Student
        {
            Id = 2,
            Name = "Wednesday",
            Address =  "21 Chester Place",
            AttendanceRecorded = false,
            AttendanceValue= true
        },

        new Student
        {
            Id = 3,
            Name = "Fry",
            Address =  "apartment 00100100",
            AttendanceRecorded = true,
            AttendanceValue= true
        },

        new Student
        {
            Id = 4,
            Name = "Ash",
            Address =  "Pallet Town",
            AttendanceRecorded = true,
            AttendanceValue= true
        },

        new Student
        {
            Id = 5,
            Name = "Buttercup",
            Address =  "107 Pokey Oaks, Townsville",
            AttendanceRecorded = true,
            AttendanceValue= true
        }
    };
var teacher = new TeachingAssistant // explicit would be TeachingAssistant blueberry = new TeachingAssistant e.g
{// blueberry block- code that tells the prog how we want this TA- what property values we want to assign to it

    Id = 6,
    Name = "Cruella",
    Address = "Hell Hall ",
    AttendanceRecorded = true,
    AttendanceValue = true,
    CollegeEmailAddress = "Dontemailme@hotmail.com",
    TookAttendance = students.All(x => x.AttendanceRecorded == true) // checking if all are true

};

Student banana = new Student();// exp: telling it the type before the = 
banana.Name = "lisa";


bool showMenu = true; //variable declartion, then instantiation (primative type e.g bool) 
MainMenu menu = new(students, teacher);
while (showMenu == true) // debug 
{
    showMenu = menu.ShowMenu(); //loop through until showMenu = false. MainMenu is a method we made - yellow for function 
}

//while showMenu == true, showMenu is equal to MainMenu()

    
  