using System;

namespace  Conditional
{
    class Program 
    {
        static void Main(string[] args)
        {
            int theVal = 50;

            //if-else 
            if (theVal == 50) 
            {
                Console.WriteLine("theVal is 50");

            }
            else if (theVal >= 51 && theVal <= 60) 
            {
                Console.WriteLine("theVal is between 51 and 60");
            }
            else 
            {
                Console.WriteLine("theVal is something else");
            }

            //---------------------------------------
            //Using the ternary operator ? :

            // A ternary operator is a shorthand way of writing an if-else statement in many programme languages
             //It allows you to perform a quick conditional evaluation and return a value based on the result of the condition 

             //condition? expression1 : expression2
             // Here's how it works: 

             //The "condition" is a Boolean expression that evaluates to either true or false
             //if  the condition is true, the ternary operator returns the value of "expression1"
             //If the condition is false, the ternary operator returns the value of "expression2"

             //a two-case if-then 
             if (theVal < 50)
             {
                Console.WriteLine("theVal is small");
             }
             else{
                Console.WriteLine("theVal is large");
             }

             //can be replaced by a ternary operator?: 
             Console.WriteLine(theVal <50? "theVal is small" : "theVal is large");

             //--------------------------
             //More examples using the ternary operator : 

             //Example 1 : Check if a number is positive or negative 
             int number = -10;
             string result = number >= 0? "Positive" : "Negative";
             Console.WriteLine("The number is " + result );

             //Example 2 : Check if a person is eligible to vote based on age 
             int age = 20;
             string eligibility = age >= 18 ? "Eligible to vote" : "Not eligible to vote";
             Console.WriteLine(eligibility);

        }
    
    }
}