using System;
using System.Globalization;

//in this example, we are going to see how to parse the contents of a string into native C# data types and again.
//this is a pretty common operation that programs have to perform, Your program might be given something lke 
// numerical data in string format and you need to convert it into an actual number. 
namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = "1";
            string numStr2 = "2.00";
            string numStr3 = "3,000";
            string numStr4 = "3,000.00";

            //you can only do this with a floating point number into an integer if the decimal point value
            // is zero. So that's why I have this here 

            //The Parse function attempts to parse a string into a number
            //but it might throw an exception, so we need to catch that 
            int targetNum;

            //The reason I'm going to put this inside a try catch block is because the parse function might throw
            //an exceptions, which we learned about earlier.So I have a try catch  handler to catch any 
            //exceptions that might happen 
            try{
                //So the different basic data types in C# provide a parse function that you can use to parse
                // a string into that particular type.And you can also specify that certain formats are allowed as well

                //use Parse to try a simple integer
                targetNum = int.Parse(numStr1);
                Console.WriteLine($"{targetNum}");

                // what I'm going to do here is I'm going to tell the parser to allow the floating point format 
                // And to do that, I need to use what's called NumberStyles class and that is located here in the
                //System.Globalization namespace

                //use parse to try a floating point number  
                //This only works if the decimal value is 0
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"{targetNum}");

                //Use parse to try a number with thousands marker
                targetNum = int.Parse(numStr2, NumberStyles.Float);
                Console.WriteLine($"{targetNum}");

                //use Parse to try a number with thousand marker
                targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
                Console.WriteLine($"{targetNum}");

                //Use Parse to try a number with thousands marker AND decimal
                targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
                //the single vertical bar: | 
                //The single vertical bar means OR 
                Console.WriteLine($"{targetNum}");

                //This works with other types too, like bool 
                //Here, we are passing the string "True" and this will be converted or parsed to a boolean
                Console.WriteLine($"{bool.Parse("false")}");

                //Or floating point numbers 
                Console.WriteLine($"{float.Parse("1.235"):F2}");
                Console.WriteLine($"{float.Parse("1.235"):F3}");
                Console.WriteLine($"{float.Parse("1.235"):F4}");

            }

            catch{
                Console.Write("Conversion failed");
            }


            //There actually is a convenience form of the parse function called TryParse 
            //The TryParse function is similar but handles the exceptions for us so we do not need any errors

            //This is the statement we have: 
            bool succeeded = false;
            //Int32 is a class 
            succeeded = Int32.TryParse(numStr1, out targetNum);
            if (succeeded) {
                Console.WriteLine($"{targetNum}");


                //we are going to use a feature of C# called an out parameter, which is a function parameter that is used to return a value 
                // from the function call. we're not going to be supplying this value, It's value, it's going to be giving it back to us. Now, we are going 
                //to learn more about this when we get to the chapter on functions 
            }
        }
    }
}