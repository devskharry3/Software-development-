using System;

namespace ConditionalOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 2;

            switch (choice)
            {
                case 1:
                    //example 1
                    int theVal = 50;
                    switch (theVal)
                    {
                        case 50:
                            Console.WriteLine("The value is 50");
                            break;
                        case 51:
                            Console.WriteLine("The value is 51");
                            break;
                        case 52:
                        case 53:
                        case 54:
                            Console.WriteLine("The value is between 52 and 54 ");
                            break;
                        default:
                            Console.WriteLine("The value is something else");
                            break;
                    }
                    break;

                case 2:
                    //example 2: Checking Grades
                    int scores = 85;
                    switch (scores / 10)
                    {
                        case 10:
                        case 9:
                            Console.WriteLine("A");
                            break;
                        case 8:
                            Console.WriteLine("B");
                            break;
                        case 7:
                            Console.WriteLine("C");
                            break;
                        case 6:
                            Console.WriteLine("D");
                            break;
                        default:
                            Console.WriteLine("F");
                            break;
                    }
                    break;

                case 3:
                    //example 3: Day of the week
                    int dayOfWeek = 2;
                    switch (dayOfWeek)
                    {
                        case 1:
                            Console.WriteLine("Sunday");
                            break;
                        case 2:
                            Console.WriteLine("Monday");
                            break;
                        case 3:
                            Console.WriteLine("Tuesday");
                            break;
                        case 4:
                            Console.WriteLine("Wednesday");
                            break;
                        case 5:
                            Console.WriteLine("Thursday"); 
                            break;
                        case 6:
                            Console.WriteLine("Friday");
                            break;
                        case 7:
                            Console.WriteLine("Saturday");
                            break;
                        default:
                            Console.WriteLine("Invalid day");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
