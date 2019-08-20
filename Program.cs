using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            Task1_1 task1_1 = new Task1_1();
            task1_1.Main1_1();

            Console.WriteLine("Task 1.2");
            Task1_2 task1_2 = new Task1_2();
            task1_2.Main1_2();

            Console.WriteLine("Task 1.3");
            Task1_3 task1_3 = new Task1_3();
            task1_3.Main1_3();

            Console.WriteLine("Task 1.4");
            Task1_4 task1_4 = new Task1_4();
            task1_4.Main1_4();

            Console.Clear();
            
            Task1_5 task1_5 = new Task1_5();
            task1_5.Main1_5();

            Console.WriteLine("Task 2.1 and 2.2");
            Task2_1_and_2_2 task2_1 = new Task2_1_and_2_2();
            task2_1.Main2_1_and_2_2();

            Console.WriteLine("Task 2.3 and 2.4");
            Task2_3_and_2_4 task2_3 = new Task2_3_and_2_4();
            task2_3.Main2_3_and_2_4();
        }
    }
}
