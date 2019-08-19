using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task1_1
    {
        public void Main1_1()
        {
            string input; // initialize variables
            int x1, x2, y1, y2;

            Console.WriteLine("Enter x1:"); // read input 
            input = Console.ReadLine();
            x1 = Convert.ToInt32(input);

            Console.WriteLine("Enter x2:");
            input = Console.ReadLine();
            x2 = Convert.ToInt32(input);

            Console.WriteLine("Enter y1:");
            input = Console.ReadLine();
            y1 = Convert.ToInt32(input);

            Console.WriteLine("Enter y2:");
            input = Console.ReadLine();
            y2 = Convert.ToInt32(input);

            Rectangle1_1 obj = new Rectangle1_1(x1,x2,y1,y2); // create the object of Rectangle class
            Console.WriteLine("Area = " + obj.calculateArea()); // call methods...
            Console.WriteLine("Perimeter = " + obj.calculatePerimeter());
        }
    }
}

class Rectangle1_1
{
    private int x1; // coordinates of rectangle vertices (x1;y1) and (x2;y2)
    private int y1;
    private int x2;
    private int y2;
    private int a; // side 'a' of rectangle
    private int b; // side 'b' of rectangle
    public Rectangle1_1(int x1, int y1, int x2, int y2) // constuctor that gets coordinates and sets the length of the sides
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
    public Rectangle1_1() { }
    public double calculateArea() // method to calculate the area of rectangle
    {
        return a*b;
    }
    public double calculatePerimeter() // method to calculate the perimeter of rectangle
    {
        return (a * 2 + b * 2);
    }
}