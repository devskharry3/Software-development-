using System; 

//The  namespace makes it easier to organize our application and 
//avoid name collisions with other code 

namespace HelloWorld  
{

//In.Net our program is contained within its own class 
class Program 
{
    //The main function is the entry point into our app 
    static void Main (string[] args)
    {
        Console.WriteLine("Hello world!");
        Console.WriteLine("What is your name?"); 

        //create a string variable ande ask the user for some input 
        string str = Console.ReadLine(); 
        Console.WriteLine("welcome, nice having you here  " + str);
    } 
}

}