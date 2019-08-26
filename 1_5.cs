using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region main
namespace Task
{
    class Task1_5
    {
        public void Main1_5()
        {
            string input1,
                input2;
            int n = 0;
            ComplexNum num1 = new ComplexNum();
            ComplexNum num2 = new ComplexNum();

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine("Enter {0} complex number:", i);
                input1 = Console.ReadLine();
                Console.SetCursorPosition(input1.Length + 1, 2 + n);
                Console.Write("+ ");
                input2 = Console.ReadLine();
                Console.SetCursorPosition(input1.Length + 3 + input2.Length, 2 + n);
                Console.WriteLine("i");

                if (n == 0)
                {
                    num1 = new ComplexNum(Convert.ToDouble(input1), Convert.ToDouble(input2));
                    n += 2;
                }
                else
                    num2 = new ComplexNum(Convert.ToDouble(input1), Convert.ToDouble(input2));
            }

            ComplexNum num3 = new ComplexNum();
            num3 = num1 * num2;
            num3 = num1 / num2;
        }
    }
}

#endregion

class ComplexNum
{
    #region variable declaration
    public double real;
    public double imaginary;
    #endregion

    #region methods
    public ComplexNum() { }
    public ComplexNum(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }
    public static ComplexNum operator * (ComplexNum first, ComplexNum second)
    {
        ComplexNum result = new ComplexNum(first.real * second.real, first.imaginary * second.imaginary);
        Console.WriteLine("Result of multiplication: {0} + {1}i", result.real, result.imaginary);
        return result;
    }
    public static ComplexNum operator / (ComplexNum first, ComplexNum second)
    {
        ComplexNum result = new ComplexNum(first.real / second.real, first.imaginary / second.imaginary);
        Console.WriteLine("Result of division: {0} + {1}i", result.real, result.imaginary);
        return result;
    }
    #endregion
}