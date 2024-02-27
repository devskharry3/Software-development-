using System;
using System.Collections.Generic;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int ID { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, ID: {ID}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();

        // Populating the list with student instances
        studentList.Add(new Student { Name = "Charles", Age = 20, ID = 101 });
        studentList.Add(new Student { Name = "Harry", Age = 21, ID = 102 });
        studentList.Add(new Student { Name = "Chloe", Age = 19, ID = 103 });

        // Printing student information
        Console.WriteLine("Student Information:");
        foreach (Student student in studentList)
        {
            student.PrintInfo();
        }

        // Removing a student
        int studentToRemoveID = 102;
        Student studentToRemove = studentList.Find(s => s.ID == studentToRemoveID);
        if (studentToRemove != null)
        {
            studentList.Remove(studentToRemove);
            Console.WriteLine($"Student with ID {studentToRemoveID} removed.");
        }
        else
        {
            Console.WriteLine($"Student with ID {studentToRemoveID} not found.");
        }
    }
}
