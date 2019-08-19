using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task2_3_and_2_4
    {
        public void Main2_3_and_2_4()
        {
            var figure = new Figure();
            var square = new Square();
            var rectangle = new Rectangle();
            figure.Draw();
            square.Draw();
            rectangle.Draw();
            Figure.DrawAll(figure, square, rectangle);
            Console.Read();
        }
    }
}

class Figure : IDrawable
{
    public readonly int x;
    public readonly int y;
    public Figure() { }
    virtual public void Draw()
    {
        Console.WriteLine("Draw a Figure!");
    }
    static public void DrawAll(params IDrawable[] array)
    {
        foreach (var item in array)
        {
            item.Draw();
        }
    }
}
class Square : Figure
{
    public Square() : base() { }
    override public void Draw()
    {
        Console.WriteLine("Draw a Square!");
    }
}
class Rectangle : Figure
{
    public Rectangle() : base() { }
    override public void Draw()
    {
        Console.WriteLine("Draw a Rectangle!");
    }
}

public interface IDrawable
{
    void Draw();
}