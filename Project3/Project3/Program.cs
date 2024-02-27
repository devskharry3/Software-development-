using System; 

namespace VarsAndData 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //declare some basic value type variables 
            int i = 10; 
            float f = 2.0f; 
            decimal d = 10.0m;
            bool b = true; 
            char c = 'c';


            //declare a string- it's a collection of characters 
            string str = "a string"; 

            //declare an implicit variable 
            var x = 10; 
            var z = "Hello"; 

            //declare an array of values 
            int[] vals = new int[5];
            string[] strs = {"one", "two", "three"};

            //Print the values using a Formatting String 
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, c, b, str, f, d, x, z);


            //"null" means "no value" 
            object obj = null; 
            Console.WriteLine(obj);

            //implicit conversion between types 
            long bignum; 
            bignum = 1;

            //Explicit conversion 
            float i_to_f = (float)i;
            Console.WriteLine("{0}", i_to_f);

        }
    }
}