using System;

class Lecturer{
    
    public string Name {get; set;}
     public int Age {get; set;}
    public string Department {get; set;}

    //constructor to initialize the member veriables
    public Lecturer(string n, int a, string d) {
        Name = n;
        Age = a;
        Department = d;
    }

    //define a public member function called introduce that prints the lecturer's name,age and department to the console 
    public void Introduce() {
        Console.WriteLine($"Hi, my name is {Name} and i'm a lecturer in the {Department} department");
        Console.WriteLine($"I'm  {Age} years old");

    }

    //define a public memeber function called teach that prints a message to the console indicating the lecturer is teaching a class 
    public void Teach() {
        Console.WriteLine("Teaching a class...");
    } 

    //define a public member function called setdetails that prompts the user to enter the lecturer's name,age and department 
    //sets the corresponding memeber variables in the lecturer object
     public void SetDetails() {
        Console.Write("Enter lecturer's name:  ");
        Name = Console.ReadLine();

        Console.Write("Enter lecturer's age");
        Age = int.Parse(Console.ReadLine()); 

        

        Console.Write("Enter lecturer department:  ");
        Department = Console.ReadLine();
     } 
}

class program{
    static void Main(string[] args) {
        //create six lecturer objects
        Lecturer lecturer1 = new Lecturer("jones", 35, "computer-science");
        Lecturer lecturer2 = new Lecturer("Sarah", 42, "Mathematics");
        Lecturer lecturer3 = new Lecturer("David", 29, "Biology");
        Lecturer lecturer4 = new Lecturer ("", 0, "");
        Lecturer lecturer5 = new Lecturer("", 0, "");
        Lecturer lecturer6= new Lecturer ("", 0, "");

        //Prompt the user to enter the details for lecturer 4,5,6
        Console.WriteLine("Enter details for lecturer 4: ");
        lecturer4.SetDetails();

        Console.ReadLine();

        Console.WriteLine("Enter details for lecturer 5: ");
        lecturer5.SetDetails();

        Console.ReadLine();

        Console.WriteLine("Enter details for lecturer 6: ");
        lecturer6.SetDetails();

        Console.ReadLine();

        //display information about all six lecturer's 
        Console.WriteLine("Lecturer 1 details: ");
        lecturer1.Introduce();
        lecturer1.Teach();

        Console.ReadLine();

        Console.WriteLine("Lecturer 2 details: ");
        lecturer2.Introduce();
        lecturer2.Teach();

        Console.ReadLine();

        

        Console.WriteLine("Lecturer 3 details: ");
        lecturer3.Introduce();
        lecturer3.Teach();

        Console.ReadLine();
        

        Console.WriteLine("Lecturer 4 details: ");
        lecturer4.Introduce();
        lecturer4.Teach();

        Console.ReadLine();

        

        Console.WriteLine("Lecturer 5 details: ");
        lecturer5.Introduce();
        lecturer5.Teach();

        Console.ReadLine();

        

        Console.WriteLine("Lecturer 6 details: ");
        lecturer6.Introduce();
        lecturer6.Teach();

        Console.ReadLine();
    }
}