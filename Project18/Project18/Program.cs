using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some strings for the exercises
            string outstr;
            string str1 = "The quick brown fox jumps over the lazy dog.";
            string str2 = "This is a string";
            string str3 = "THIS is a STRING";
            string[] strs = { "one", "two", "three", "four" };
            string str4 = "The quick brown fountain fox jumps over the lazy dog and fox and fox and fox";

            // length of a string
            Console.WriteLine(str1.Length);

            // Access individual characters using indexing (not function call)
            Console.WriteLine(str1[14]);

            // iterate over a string like any other sequence of values
            foreach (char ch in str1)
            {
                Console.Write(ch);
                if (ch == ' ')
                {
                    Console.WriteLine(); // an empty line
                    break;
                }
            }

            // In this example (question number 5, we are discussing some of the related rules of strings.)
            // 2 + 3 * 5 - 4 + 7 / 2 * 6

            // string concatenation
            outstr = String.Concat(strs);
            Console.WriteLine(outstr);
            // Expected output: onetwothreefour

            // Joining strings together with join
            outstr = String.Join(',', strs);
            Console.WriteLine(outstr);
            // Output: one, two, three, four

            outstr = String.Join("------", strs);
            Console.WriteLine(outstr);
            // Output: one------two------three------four

            // String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are at the same position in sort order
            // > 0 : first string comes after the second in sort order
            int result = String.Compare(str2, "This is a string");
            Console.WriteLine("{0}", result);

            // Equals just returns a regular Boolean
            bool isEqual = str2.Equals(str3);
            Console.WriteLine("{0}", isEqual);

            // string Searching
            Console.WriteLine("{0}", str1.IndexOf('e'));
            Console.WriteLine("{0}", str1.IndexOf("fox"));
            // the expected output is number 16 as the index number of the starting point of the word fox is 16
            Console.WriteLine("{0}", str4.IndexOf("fox"));

            Console.WriteLine("{0}", str1.LastIndexOf('e'));
            Console.WriteLine("{0}", str1.LastIndexOf("the"));

            outstr = str1.Replace("fox", "cat");
            Console.WriteLine("{0}", outstr);
            Console.WriteLine("{0}", outstr.IndexOf("fox"));

        }
    }
}
