using System;
using System.Text;

namespace StringBuilderExample
{
    class Program 
    {
        static void Main(string[] args)
        {
            //initialize a StringBuilder with an initial string and capacity
            StringBuilder sb = new StringBuilder("Initial String." , 200);
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            //Print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

            //Append some strings to the builder using Append 
            sb.Append("The quick brown fox");
            sb.Append("jumps over the lazy dog.");
            sb.Append("I am the word being added to the end of whatever you already had in your SB.");
            Console.WriteLine($"Capacity: {sb.Capacity}; Length:{sb.Length}");
            Console.WriteLine("The latest version of the StringBuilder after the updates is: ");
            Console.WriteLine(sb);

            //AppendFormat can be used to append a line ending 
            sb.AppendLine();

            //AppendFormat can be used to append formatted strings
            sb.AppendFormat("He did this {0} times. ", jumpCount);
            Console.WriteLine($"Cleared. Capacity: {sb.Capacity}; Length:{sb.Length}");


            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine();

            //AppendJoin can be used to iterate over a set of values
            sb.AppendLine(); //whatever you are going to add to the string in the 
            //following syntaxes, will be placed in a separate line inside the same string

            sb.Append("He also jumped over ");
            sb.AppendJoin(",", animals);
            Console.WriteLine($"Cleared. Capacity: {sb.Capacity}; Length: {sb.Length}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine();
            

            //modify the content using replace
            sb.Replace("fox", "cat");
            Console.WriteLine(sb); //it works but it is not neccessary
            Console.WriteLine($"Cleared. Capacity: {sb.Capacity}; Length: {sb.Length}");


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //insert content at any index
            sb.Insert(0, "This is me"); //12 characters

            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine();
            

            //print current capacity and length of the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            // the initial capacity was 200
            // 200 + 12 = 212 

            //Insert content at any index
            sb.Insert(10, "This is the");

            Console.WriteLine();
            Console.WriteLine(sb);
            Console.WriteLine();
            
            //Print current capacity and length of the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");
            
            //212 + 12 = 224 

            //convert the StringBuilder to a single string and print it 
            Console.WriteLine(sb.ToString());

            //Additional examples 

            //clear the StringBuilder and reset its length 
            sb.Clear();
            Console.WriteLine($"Cleared. Capacity: {sb.Capacity}; Length: {sb.Length}");

            //Append a repeated character '-' twenty times and a new line 
            sb.Append('-', 20);
            sb.AppendLine();
            Console.WriteLine(sb.ToString());

            //Insert a formatted currency value at the beginning
            sb.Insert(0, string.Format("Total: {0:N2} USD", 12345.6789));
            Console.WriteLine(sb.ToString());

            //Append new lines with indentation 
            sb.Clear();
            sb.AppendLine("Hello, ");
            sb.Append('\t').AppendLine("world!");
            sb.AppendLine("Welcome to the StringBuilder example.");
            Console.WriteLine(sb.ToString());

            //Remnove characters from the middle 
            sb.Remove(6,0);
            Console.WriteLine("This is the (6,0): ");
            Console.WriteLine(sb);

            sb.Remove(6,1);
            Console.WriteLine("this is the (6,1):");
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.WriteLine();
            

            sb.Remove(6,2);
            Console.WriteLine("this is the (6,2):");
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.WriteLine();


            sb.Remove(6,3);
            Console.WriteLine("this is the (6,3):");
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.WriteLine();
            
            //sb.Remove(6,4); //removes 'World'
            // console.WriteLine(sb,ToString());

            sb.Remove(6,4);
            Console.WriteLine("this is the (6,4:");
            Console.WriteLine(sb);
            Console.WriteLine();
            Console.WriteLine();
            


            

        
        
        }
    }
}