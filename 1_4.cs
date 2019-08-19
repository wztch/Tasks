using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Main

namespace Task
{
    class Task1_4
    {
        public void Main1_4()
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

            Rectangle1_4.Initialize(x1, x2, y1, y2);
            Console.WriteLine("Area = " + Rectangle1_4.calculateArea());
            Console.WriteLine("Perimeter = " + Rectangle1_4.calculatePerimeter());

            double radius;
            Console.Write("Enter radius of Circle: ");
            radius = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Area of circle: " + Circle1_4.calculateArea(radius));
            Console.WriteLine("Length of circle: " + Circle1_4.calculateLength(radius));
        }
    }
}
#endregion

#region Task 4 Rectangle
static class Rectangle1_4
{
    static private int x1; // coordinates of rectangle vertices (x1;y1) and (x2;y2)
    static private int y1;
    static private int x2;
    static private int y2;
    static private int a; // side 'a' of rectangle
    static private int b; // side 'b' of rectangle
    static public void Initialize(int x1, int y1, int x2, int y2) // initializer
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
    static public double calculateArea() // method to calculate the area of rectangle
    {
        return a * b;
    }
    static public double calculatePerimeter() // method to calculate the perimeter of rectangle
    {
        return (a * 2 + b * 2);
    }
}
#endregion

#region Task 4 Circle

static class Circle1_4
{
    static private double radius;
    private const double pi = 3.14; // constant value - Pi

    static public double calculateArea(double radius) // method to calculate the Area of the Circle
    {
        return pi * radius * radius;
    }
    static public double calculateLength(double radius) // method to calculate the Length of the Circle
    {
        return 2 * pi * radius;
    }
}
#endregion