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
            int choice;

            Console.WriteLine("Run task:\n1.1 - 1\n" +
                "1.2 - 2\n" +
                "1.3 - 3\n" +
                "1.4 - 4\n" +
                "1.5 - 5\n" +
                "2.1 and 2.2 - 6\n" +
                "2.3 and 2.4 - 7\n" +
                "3.1 - 8\n" +
                "3.2 - 9\n" +
                "3.3 - 0");

            choice = Int32.Parse(Console.ReadLine());
            Console.Clear();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Task 1.1");
                    Task1_1 task1_1 = new Task1_1();
                    task1_1.Main1_1();
                    break;
                case 2:
                    Console.WriteLine("Task 1.2");
                    Task1_2 task1_2 = new Task1_2();
                    task1_2.Main1_2();
                    break;
                case 3:
                    Console.WriteLine("Task 1.3");
                    Task1_3 task1_3 = new Task1_3();
                    task1_3.Main1_3();
                    break;
                case 4:
                    Console.WriteLine("Task 1.4");
                    Task1_4 task1_4 = new Task1_4();
                    task1_4.Main1_4();
                    break;
                case 5:
                    Console.WriteLine("Task 1.5");
                    Task1_5 task1_5 = new Task1_5();
                    task1_5.Main1_5();
                    break;
                case 6:
                    Console.WriteLine("Task 2.1 and 2.2");
                    Task2_1_and_2_2 task2_1 = new Task2_1_and_2_2();
                    task2_1.Main2_1_and_2_2();
                    break;
                case 7:
                    Console.WriteLine("Task 2.3 and 2.4");
                    Task2_3_and_2_4 task2_3 = new Task2_3_and_2_4();
                    task2_3.Main2_3_and_2_4();
                    break;
                case 8:
                    Console.WriteLine("Task 3.1");
                    Task3_1 task3_1 = new Task3_1();
                    task3_1.Main3_1();
                    break;
                case 9:
                    Console.WriteLine("Task 3.2");
                    Task3_2 task3_2 = new Task3_2();
                    task3_2.Main3_2();
                    break;
                case 0:
                    Console.WriteLine("Task 3.3");
                    Task3_3 task3_3 = new Task3_3();
                    task3_3.Main3_3();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            Console.Read();
        }
    }
}
