using System;

class Shape{
    public float length {get; set;}
    public float breadth {get; set;}
    //default constructor
    public Shape(){
        length = 10.5f;
        breadth = 8.50f;
    }
    //parameterized constructor
    public Shape(float length, float breadth){
        this.length = length;
        this.breadth = breadth;
    }
}

class Rectangle:Shape{
    public Rectangle(float length, float breadth):base(length, breadth){}

    public void CalculateArea(){
        double area = length*breadth;
        Console.WriteLine("The area of rectangle is {0}", area);
    }
}

class Program{
    static void Main(){
        Rectangle r = new Rectangle(10.5f, 8.50f);
        r.CalculateArea();
    }
}

