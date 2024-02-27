using System;

class Lecturer{
    //public member
    public string Name{get; set;}
    public int Age{get; set;} 
    public string Department{get; set;}

    private string Office{get; set;}
    private string Email{get; set;}
    private double Salary{get; set;}

    //constructor to initialize all the member variables
    public Lecturer(string n, int a, string d, string o, string e, double s) {
        Name = n;
        Age = a;
        Department = d;
          Office = o;
          Email = e;
          Salary = s;
        
    }

    //Public method to introduce the lecturer
    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {Name} and i'm a lecturer in the {Department} departemnt ");
        Console.WriteLine($"I'm {Age} years old ");
        Console.WriteLine($"My office is {Office} and my email is {Email} ");
        Console.WriteLine($"My salary is ${Salary} ");
    }

    //Public method to indicate teaching 
    public void Teach()
    {
        Console.WriteLine("Teaching a class.....");
    }

    //Public method to set details for the lecturer
    public void SetDetails()
    {
         Console.Write("Enter lecturer's name:  ");
        Name = Console.ReadLine();

        Console.Write("Enter lecturer's age: ");
        Age = int.Parse(Console.ReadLine()); 

        
        Console.Write("Enter lecturer department:  ");
        Department = Console.ReadLine();

        Console.WriteLine("Enter lecturer office:");
        Office = Console.ReadLine();

        Console.WriteLine("Enter lecturer email: ");
        Email = Console.ReadLine();

        Console.WriteLine("Enter lecturer salary: ");
        Salary = int.Parse(Console.ReadLine());
        

    }

    class program {
        static void Main(string[] args) {
            //create lecturer objects with initial values
            Lecturer lecturer1 = new Lecturer("John", 35, "Computer Science", "A101", "john@example.com", 5000);
            Lecturer lecturer2 = new Lecturer("Sarah", 42, "Mathematics", "B201", "sarah@example.com", 6000);
            Lecturer lecturer3 = new Lecturer("David", 28, "Biology", "C301", "david@example.com", 5500);
            Lecturer lecturer4 = new Lecturer("", 0, "", "", "",  0);

            //Prompt user details for lecturer4
            Console.WriteLine("Enter details for lecturer 4: ");
            lecturer4.SetDetails();

            Console.ReadLine();

            //Display details and perform actions for each lecturer
            Console.WriteLine("Lecturer 1 details ");
            lecturer1.Introduce();
            lecturer1.Teach();

            Console.ReadLine();

            Console.WriteLine("Lecturer 2 details ");
            lecturer2.Introduce();
            lecturer2.Teach();

            Console.ReadLine();

            Console.WriteLine("Lecturer 3 details ");
            lecturer3.Introduce();
            lecturer3.Teach();

            Console.ReadLine();

            Console.WriteLine("Lecturer 4 details");
            lecturer4.Introduce();
            lecturer4.Teach();
        }
    }
}