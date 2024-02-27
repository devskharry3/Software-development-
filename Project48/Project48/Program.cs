using System;

class Lecturer
{
    public string name;
    private double salary;
    protected string researchArea;

    public Lecturer(string n, double s) 
    {
        name = n;
        salary = s;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hi, my name is {name}  ");
        Console.WriteLine($"My salary is ${salary}.");
        Console.WriteLine($"My research area is {researchArea}.");
    }

    public void Teach() 
    {
        Console.WriteLine("Teaching a class");
    }

    public void SetDetails()
    {
        Console.Write("Enter lecturer's name:");
        name = Console.ReadLine();

        Console.Write("Enter lecturer's salary ");
        salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter lecturer's research area: ");
        researchArea = Console.ReadLine();
    }
}

class Student
{
    public string name;
    private int studentID;
    protected string major;

    public Student(string n, int id)
    {
        name = n;
        studentID = id;
    }

    public void Introduce() 
    {
        Console.WriteLine($"Hi, my name is{name}");
        Console.WriteLine($"My student ID is {studentID}.");
        Console.WriteLine($"My major is {major}.");
    }

    public void Study()
    {
        Console.WriteLine("Studying.....");
    }

    public void SetDetails()
    {
        Console.WriteLine("Enter student's ID: ");
        studentID = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter student's major:");
        major = Console.ReadLine();
    }
}

class program
{
    static void Main(string[] args)
    {
        Lecturer lecturer = new Lecturer("John", 5000);
        Student student = new Student("Alice", 12345);

        Console.WriteLine("Enter details for lecturer:");
        lecturer.SetDetails();
        Console.WriteLine();

        Console.WriteLine("Enter details for student:");
        student.SetDetails();
        Console.WriteLine();

        Console.WriteLine("Lecturer details:");
        lecturer.Introduce();
        lecturer.Teach();
        Console.WriteLine();

        Console.WriteLine("Student details:");
        student.Introduce();
        student.Study();
        Console.WriteLine();
    }
}