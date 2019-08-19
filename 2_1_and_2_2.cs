using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task2_1_and_2_2
    {
        public void Main2_1_and_2_2()
        {
            string input;
            int x, y;
            Console.WriteLine("Enter x:");
            input = Console.ReadLine();
            x = Convert.ToInt32(input);
            Console.WriteLine("Enter y:");
            input = Console.ReadLine();
            y = Convert.ToInt32(input);
            var square = new Square2_1_and_2_2(x, y);
            var rectangle = new Rectangle2_1_and_2_2(x, y);
            square.Draw();
            rectangle.Draw();
        }
    }
}

abstract class Figure2_1_and_2_2
{
    public readonly int x;
    public readonly int y;

    public Figure2_1_and_2_2(int x, int y)
    {
        this.x = x;
        this.y = y;
        Console.WriteLine("x = {0}\ny = {1}", this.x, this.y);
    }
    abstract public void Draw();
}
class Square2_1_and_2_2 : Figure2_1_and_2_2
{
    public Square2_1_and_2_2(int x, int y) : base(x, y)
    {
        Console.WriteLine("Square constructor!");
    }
    override public void Draw()
    {
        Console.WriteLine("Draw a Square!");
    }
}
class Rectangle2_1_and_2_2 : Figure2_1_and_2_2
{
    public Rectangle2_1_and_2_2(int x, int y) : base(x, y)
    {
        Console.WriteLine("Rectangle constructor!");
    }
    override public void Draw()
    {
        Console.WriteLine("Draw a Rectangle!");
    }
}
