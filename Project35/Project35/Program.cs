using System;

namespace RefAndOutParams {
    class Program{
        //Ordinary value arguments cannot be modified by the function
        //because they are copy of the original value
        static void TestFunc1(int arg1) {
            arg1 += 10;
            //The change we've made in the above line is just a temporary
            //change inside this function
            //because the function receives a copy of the value in the
            //argument when it is passed in 
            Console.WriteLine($"{arg1}");
        }

        //Arguments that are passed by reference can be modified
        //by the function and reflected back to the caller
        static void TestFunc2(ref int arg1) {
            arg1 +=10;
            Console.WriteLine($"{arg1}");
        }

        //There's one other interesting keyword called out, which specifies
        // that a paramter is used to return a value instead of supplying data
        //to the function
        //the "out" keyword means that the parameter returns a value and is not
        //used to supply data to the function 

        //this function has two inputs: arg1 and arg2
        // and has two outputs or return values: sum and product
        static void PlusTimes(int arg1, int arg2, out int sum, out int product) {
            sum = arg1 + arg2;
            product = arg1 * arg2;
        }

        static void Main(string[] args) {
            int val1 = 30;
            int val2 = 20;

            //functions don't normally modify value arguments
            TestFunc1(val1);
            Console.WriteLine($"{val1}");

            //using the "ref" keyword, arguments can be passed by reference
            // which allows the function to modify them
            //what this keyword does is it indicates to the compiler that the
            //argument is being passed as a reference, instead of a copy
            //so now the function does have the ability to change the value,
            // and have that change be reflected outside the function
            TestFunc2(ref val1);
            Console.WriteLine($"{val1}");

            //The "out" keyword can be used to indicate than an argument
            //is intended to return a value and is not an input
            int a,b;
            PlusTimes(val1, val2, out a, out b);
            Console.WriteLine($"{a}, {b}");
            //the main purpose of the out parameter is to enable a function
            // to return multiple value and you might see this in older C# 
            //code, However, this isn't really the recommended way to do this
            //anymore, so while you might see this in older C# code there's
            // a newer way to return multiple values, and that's by using
            // what's called a tuple structure
        }
    }
}