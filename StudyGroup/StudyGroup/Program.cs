using StudyGroup; // this is the namespace
using System.Text.Json;
//using System.Text.Json;


bool showMenu = true; //variable declartion, then instantiation (primative type e.g bool) 
while (showMenu == true) // debug 
{
    showMenu = MainMenu(); //loop through until showMenu = false. MainMenu is a method we made - yellow for function 
}

//while showMenu == true, showMenu is equal to MainMenu()

static bool MainMenu() // define what mm does 
{
    var strawberry = new List<Student> //Impicit: variable strawberry, explict would be List<Student> strawberry
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
    var blueberry = new TeachingAssistant // explicit would be TeachingAssistant blueberry = new TeachingAssistant e.g
    {// blueberry block- code that tells the prog how we want this TA- what property values we want to assign to it

        Id = 6,
        Name = "Cruella",
        Address = "Hell Hall ",
        AttendanceRecorded = true,
        AttendanceValue = true,
        CollegeEmailAddress = "Dontemailme@hotmail.com",
        TookAttendance = strawberry.All(x => x.AttendanceRecorded == true) // checking if all are true

    };

    Student banana = new Student();// exp: telling it the type before the = 
    banana.Name = "lisa";

    foreach (var orange in strawberry) // implicit variable declared orange // foreach is a finate loop
    {
        if (orange.AttendanceRecorded == false) // == is comparison - checking if any are false
        {
            blueberry.TookAttendance = false; // = is assignment 
        }
    }


    //Console.WriteLine("T.A: " + System.Text.Json.JsonSerializer.Serialize(blueberry));

    //Console.WriteLine("students: " + JsonSerializer.Serialize(students));

    //var studentfunctions = new StudentFunctions();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Input New Student");
    Console.WriteLine("2) See all students");
    Console.WriteLine("3) See student by ID");
    Console.WriteLine("4) Update Student");
    Console.WriteLine("5) Exit");
    Console.Write("\r\nSelect an option: ");

    var pear = Console.ReadLine(); // variables can be values OR the result of a function execution, which is what we have here (read what is written, and save to Pear) 

    switch (pear) // in this case, switch on user imput- if you type in 1 or 2 etc. Like IF statement.
    {
        case "1":
            Console.WriteLine("\n");
            Console.WriteLine("Input New Student");
            Console.WriteLine("Enter New Id");
            var lemon = Console.ReadLine();
            Console.WriteLine("Enter New Student Name");
            var fish = Console.ReadLine();
            Console.WriteLine("Enter New Student Address");
            var koala = Console.ReadLine();
            Console.WriteLine("Enter Attendance Recorded");
            var lion = Console.ReadLine();
            Console.WriteLine("Enter Attendance Value");
            var cow = Console.ReadLine();
            var penguin = StudentFunctions.CreateStudent(int.Parse(lemon),fish, koala, Boolean.Parse(lion), Boolean.Parse(cow));
            strawberry.Add(penguin);
            Console.WriteLine("\n");
            Console.WriteLine(JsonSerializer.Serialize(penguin));
            Console.WriteLine("\n");
            return true; // return bool, exits out of function. See Break by comparison which exits out of switch statement 
        case "2":
            Console.WriteLine("\n");
            Console.WriteLine("List of Students \n" + System.Text.Json.JsonSerializer.Serialize(strawberry));
            Console.WriteLine("\n");
            return true;
        case "3":
            Console.WriteLine("\n");
            Console.WriteLine("Enter Id");
            var inputId = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(strawberry.FirstOrDefault(x => x.Id == int.Parse(inputId)))); // linq query: get student which matches input
            Console.WriteLine("\n");
            return true;
        case "4":
            Console.WriteLine("\n");
            Console.WriteLine("Enter Id");
            var updateId = Console.ReadLine();
            Console.WriteLine("\n");
            var studentToUpate = strawberry.FirstOrDefault(x => x.Id == int.Parse(updateId));
            Console.WriteLine("\n");
            Console.WriteLine("Student Name; " + studentToUpate.Name); 
            Console.WriteLine("Do you want to update this value? Y/N");
            var updateName = Console.ReadLine();
            if (updateName.ToUpper() == "Y")
            {
                Console.WriteLine("Enter new value");
                var newValue = Console.ReadLine();
                studentToUpate.Name = newValue;
            }
            Console.WriteLine("Student Address; " + studentToUpate.Address); // string interpalation - 
            Console.WriteLine("Do you want to update this value? Y/N");
            var updateAddress = Console.ReadLine();
            if (updateAddress.ToUpper() == "Y")
            {
                Console.WriteLine("Enter new value");
                var newValue = Console.ReadLine();
                studentToUpate.Address = newValue;
            }
            Console.WriteLine("Student Attendance Recorded; " + studentToUpate.AttendanceRecorded);
            Console.WriteLine("Do you want to update this value? Y/N");
            var updateAttendanceRecorded = Console.ReadLine();
            if (updateAttendanceRecorded.ToUpper() == "Y")
            {
                Console.WriteLine("Enter new value");
                var newValue = Console.ReadLine();
                studentToUpate.AttendanceRecorded = Boolean.Parse(newValue);
            }
            Console.WriteLine("Student Attendance Value; " + studentToUpate.AttendanceValue);
            Console.WriteLine("Do you want to update this value? Y/N");
            var updateAttendanceValue = Console.ReadLine();
            if (updateAttendanceValue.ToUpper() == "Y")
            {
                Console.WriteLine("Enter new value");
                var newValue = Console.ReadLine();
                studentToUpate.AttendanceValue = Boolean.Parse(newValue);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Updated Record \n" + System.Text.Json.JsonSerializer.Serialize(studentToUpate));
            return true;
        case "5":
            return false; // returns false for mm, will exit
        default:
            return true; // if they type in anything 
    }
} // mm is being ran instde a loop. 
// because variable that the While loop is looking at has been set to equal the value returned by the mm function, if the mm func returns true the while loop continues, keeps running mm func
// however if mm returns false, while loop stops 
