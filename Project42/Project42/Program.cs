using System;

class MyClass {
    public int value;

    //A parameter constructor to set the initial value 
    public MyClass (int initialValue) {
        value = initialValue;
    }

    public void PrintValue() {
        Console.WriteLine("Value is " + value);
    }
}

class Program {
    static void Main(string[] args) {
        //creating an instance of MyClass with an initial value of 5
        MyClass myObject = new MyClass(5);

        //Accessing object member using dot notation
        myObject.PrintValue();

        //let's demonstrate object references and memory management
        MyClass anotherObject = myObject; //Both references now point to  the same object
        anotherObject.value = 10; //Modifying through one references affects the object

        myObject.PrintValue(); //This will  output "value  is 10" because both references point to the same
        anotherObject.PrintValue(); //This will alsooutput "Value is 10"

        //Now, let's talk about garbage collection
        //Since the Main method scope is about to end, both object references will go out of scope
        //This means that the objects are eligibe for garbage collection
        //However, you don't need to explicitly cll GC.Collect() in this scenario

        //The following code is not necessary:
        //GC.Collect();

        //The objects will be automatically collected by the garbage collector when deemed necessary.

        Console.ReadLine();  
    }
}