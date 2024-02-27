namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            //Basic while loop executes while the gate condition is true 
            Console.WriteLine("Basic while() loop:");
            while (inputStr != "exit")
            {
                inputStr = Console.ReadLine();

                Console.WriteLine("You entered: {0}", inputStr);
            }
            Console.WriteLine();

            //The do-while loop always executes at least one time
            Console.WriteLine("The do-while() loop:");
            do
            {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            } while (inputStr != "exit");
            Console.WriteLine();


            //Calculate factorial using a while loop 
            Console.WriteLine("Calculate a Factorial using while() loop:");
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            int counter = 1;

            while(counter <= number)
            {
                factorial *= counter;
                counter++;
            }
            Console.WriteLine("Factorial of {0} is: {1}", number, factorial);
            Console.WriteLine();




            //Generate Fibonacci sequence using a while loop
            Console.WriteLine("Generate Fibonacci Sequence using while() loop:");
            Console.Write("Enter the length of Fibonacci sequence:");
            int length = int.Parse(Console.ReadLine());

            int prev = 0;
            int current = 1;
            int fibCounter = 1;

            Console.Write("Fibonacci Sequence: ");
            while (fibCounter <= length) 
            {
                Console.Write(prev + " ");

                int next = prev + current; 
                prev = current; 
                current = next;

                fibCounter++;
            }
            Console.WriteLine();
            
        }
    }
}