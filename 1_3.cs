using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task1_3
    {
        public void Main1_3()
        {
            double radius;
            Console.Write("Enter radius of Circle: ");
            radius = Int32.Parse(Console.ReadLine());
            Circle1_3 obj = new Circle1_3(radius);
        }
    }
}

class Circle1_3
{
    private double radius;
    private const double pi = 3.14; // constant value - Pi

    public double calculateArea(double radius) // method to calculate the Area of the Circle
    {
        return pi * radius * radius;
    }

    public Circle1_3(double radius)
    {
        this.radius = radius;
        Console.WriteLine("Area of circle: " + calculateArea(this.radius));
        Console.WriteLine("Length of circle: " + calculateLength(this.radius));
    } // constructor

    public double calculateLength(double radius) // method to calculate the Length of the Circle
    {
        return 2 * pi * radius;
    }
}
    