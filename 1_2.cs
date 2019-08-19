using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task1_2
    {
        public void Main1_2()
        {
             // initialize variables
            int x1, x2, y1, y2;

            Console.WriteLine("Enter x1:"); // read input 
            x1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter x2:");
            x2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y1:");
            y1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter y2:");
            y2 = Int32.Parse(Console.ReadLine());

            Rectangle1_2 obj = new Rectangle1_2(x1, x2, y1, y2); // create the object of Rectangle class
            Console.WriteLine("Area = " + obj.calculateArea()); // call methods...
            Console.WriteLine("Perimeter = " + obj.calculatePerimeter());
        }
    }
}

class Rectangle1_2
{
    private int x1 { get; set; } // coordinates of rectangle vertices (x1;y1) and (x2;y2)
    private int y1 { get; set; }
    private int x2 { get; set; }
    private int y2 { get; set; }
    private int a { get; set; } // side 'a' of rectangle
    private int b { get; set; } // side 'b' of rectangle
    public Rectangle1_2(int x1, int y1, int x2, int y2) // constuctor that gets coordinates and sets the length of the sides
    {
        if (x1 > x2)
            a = x1 - x2;
        else
            a = x2 - x1;
        if (y1 > y2)
            b = y1 - y2;
        else
            b = y2 - y1;
    }
    public Rectangle1_2() { }
    public double calculateArea() // method to calculate the area of rectangle
    {
        return a * b;
    }
    public double calculatePerimeter() // method to calculate the perimeter of rectangle
    {
        return (a * 2 + b * 2);
    }
}