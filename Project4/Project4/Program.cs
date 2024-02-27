using System;

namespace Operators 
{
    class Program 
    {

        static void Main(string[] args)
        {

        //declare some variables to exercise the operators 
        int x= 10, y= 5;
        string a="abcd", b="efgh";

        //Basic math operators are +,-,/, * 
        Console.WriteLine("------ Basic Math------");
        // int d, e;
        //d = x/y
        // e = d* x
        // Console.WriteLine(e) 
        Console.WriteLine((x/y) * x);
        Console.WriteLine(a+b);


        //Increment/decrement operators 
        Console.WriteLine("--------- Shorthand--------");
        x++; //x = x+1 
        y--; // y = y-1 
        Console.WriteLine(x);
        Console.WriteLine(y);

        //opeators can be shorthand: a = a + b 
        a +=b; //a = a+b 
        Console.WriteLine(a); 

        // Logical operators &&, || 
        Console.WriteLine("---------Logic Operators--------");
        Console.WriteLine(x > y && y >= 5);
        Console.WriteLine(x >y || y>=5);

        //null-coalescing operators 
        string str = null; 
        //the ?? operator uses left operand if not null, or right one if it is null
        Console.WriteLine(str?? "Unknown string");

        //the ??= operator assigns the right operand if the left one is null
        // it replaces the code: 
        // if (variable is null) {
        // variable = somevalue;
     //}
     str??= "New string"; 
     Console.WriteLine(str); 

     //--------------------------------------

     //null-coalenscing operators 
     string str1 = "In-class Practice";
     //the ?? operator uses left operand if not null, or right one if it is null 
     Console.WriteLine(str1?? "Unknown string");

     //the ??= operator assigns the right operand if the left one is null 
     //it replaces the code:
     //if (variable is null) {
    // variable = somevalue;
    // }
    str1 ??= "New string"; 
    Console.WriteLine(str1); 
    }
}
}