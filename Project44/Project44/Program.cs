using System;

//Class definition for a simple rectangle
class Rectangle {
    public int width, height;

    public int GetArea() {
        return width * height;
    }
}

class Program {
    static void Main(string[] args) {
        //Example 1: Create an instance of Rectangle
        Rectangle rect1 = new Rectangle();

        //set the width and height of the Rectangle object
        rect1.width = 5;
        rect1.height = 10;

        //call the GetArea method of the rectangle object
        int area1 = rect1.GetArea();

        //print the area to the console
        Console.WriteLine("Area of rectangle 1:" + area1);

        //Example2 :Create another instance of Rectangle
        Rectangle rect2 = new Rectangle();

        //set the width and height of the second rectangle object
        rect2.width = 8;
        rect2.height = 15;

        //call the GetArea method of the second Rectangle object
        int area2 = rect2.GetArea();

        //Print the area to the console
        Console.WriteLine("Area of rectangle 2: " + area2);

        //Example 3: create yet another instance of rectangle 
        Rectangle rect3 = new Rectangle();

        //set the width and height of the third rectangke object
        rect3.width = 3;
        rect3.height = 7;

        //call the GetArea method of the third Rectangle object
        int area3 = rect3.GetArea();

        //print the area to the console
        Console.WriteLine("Area of rectangle 3; " + area3);
    }
}