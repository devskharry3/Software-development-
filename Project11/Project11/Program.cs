using System;

namespace ForLoops 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            int myVal = 15;
            int[] nums = new int[] {3,14,15,92,6,10,20,30};
            string str = "The quick brown fox jumps over the lazy dog";

            //The basic for loop
            Console.WriteLine("The basic for loop:");
            for(int i = 0; i<myVal; i++) {
                Console.WriteLine("i is currently {0}", i);
            }
            Console.WriteLine();

            //the foreach-in loop can be used to iterate over the sequences
            Console.WriteLine("The foreeach loop:");
            foreach(int i in nums) {
                Console.WriteLine("i is currently {0}", i);
            }

            //Count the number of o's in the string 
            var count = 0;
            foreach (char c in str) {
                if(c == 'o') {
                    count++; //count = count + 1
                }
            }
            Console.WriteLine("Counted {0} o characters", count);
        }
    }
}