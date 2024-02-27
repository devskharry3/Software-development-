using System;

class MyClass {
    public int value;

    //constructor that accepts initial value
    public MyClass(int initialValue) {
    value = initialValue;
    }

public void PrintValue() {
    Console.WriteLine("Value is " + value);
}
}

class Program {
    static void Main(string[] args) {
    //create the first object with an initial value of 5
    MyClass firstObject = new MyClass(5);
    firstObject.PrintValue();

    //create the second object and initialize it with the value from the first object
    MyClass secondObject = new MyClass(firstObject.value);
    secondObject.PrintValue();

    //update thevalueof the second object to 10
    secondObject.value = 10;
    firstObject.PrintValue();
    secondObject.PrintValue();

    Console.ReadLine();
}
}
