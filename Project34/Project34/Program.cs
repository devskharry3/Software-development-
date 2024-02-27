using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tuples are grouped values
            (int a, int b) tup1 = (5, 10);
            var tup2 = ("Some text", 10.5);

            // Tuple values are mutable
            tup1.b = 20;
            tup2.Item1 = "New String";

            Console.WriteLine($"{tup1.a}, {tup1.b}");
            Console.WriteLine($"{tup2.Item1}, {tup2.Item2}");

            // Returning multiple values from a function using tuples
            // Functions can work with tuples
            // I'm going to get a tuple back with two integers.
            // so I'll declare my variables as having two ints and I'll call that variable result
            (int, int) result = PlusTimes(6, 12);
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");

            // Using named elements in tuples
            // Tuples can have named elements for improved readability
            var person = (FirstName: "AAA", LastName: "BBB", Age: 30);
            Console.WriteLine($"{person.FirstName} {person.LastName}, Age: {person.Age}");

            // Tuples in function parameters
            // You can use tuples as function parameters for improved organization
            DisplayPersonInfo(person);

            // Deconstructing tuples
            // Tuples can be deconstructed into separate variables
            (string firstName, string lastName, int age) = person;
            Console.WriteLine($"Deconstructed, {firstName}, {lastName}, Age: {age}");
        }

        // Functions can return multiple values using tuples
        static (int, int) PlusTimes(int a, int b)
        {
            return (a + b, a * b);
        }

        // Function with tuple parameter
        static void DisplayPersonInfo((string FirstName, string LastName, int Age) person)
        {
            Console.WriteLine($"Person: {person.FirstName} {person.LastName}, Age: {person.Age}");
        }
    }
}
