//In this C#, all objects are created on the heap memory using the keyword.C# has a
//garbage collector that automatically manages the memory for objects created on the
//heap, which simplifies memory management compared to C++


using System;

class MyClass {
    public int value;
    public void printValue() {
        Console.WriteLine("Value is " + value);
    }
}

class Program {
    static void Main(string[] args) {
        MyClass myObject = new MyClass(); //object created on the heap memory
        myObject.value = 5; //Accessing object memeber using dot notation
        myObject.printValue();

        GC.Collect(); //Freeing up the memory allocated for the object using garbage collection

        Console.ReadLine();
    }
}