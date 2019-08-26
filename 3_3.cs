using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Task3_3
    {
        public const int size = 50;
        public const int stringsPerPage = 5;
        public void Main3_3()
        {
            List<string> strList = new List<string>();
            int choice;
            string s;

            addRandom(strList);
            Console.WriteLine("Elements in List before sorting and removing: {0}", strList.Count);
            strList.Sort();
            strList.Reverse();
            removeTrash(strList);
            Console.WriteLine("Elements in List after sorting and removing: {0}", strList.Count);
            Console.Write("Page to be displayed: ");
            s = Console.ReadLine();
            if (s.All(char.IsDigit) == true)
            {
                choice = Int32.Parse(s);
                if (choice < 0 || choice <= size / 5)
                    displayPage(choice, strList);
                else
                    Console.WriteLine("No such page to display!");
            }
            else
                Console.WriteLine("Input wasn`t a number!");

            Console.Read();
        }
        public void showList(List<string> strList)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, strList[i]);
            }
        }
        public void addRandom(List<string> strList)
        {
            string str;
            char[] array = new char[4 * size];
            char[] tempArray = new char[4];
            int count = 0;
            generateRandom(array);
            for (int i = 1; i <= 4 * size; i++)
            {
                tempArray[count] = array[i - 1];
                count++;
                if (i % 4 == 0)
                {
                    str = new string(tempArray);
                    strList.Add(str);
                    count = 0;
                }
            }

        }
        public void generateRandom(char[] array)
        {
            Random num = new Random();
            for (int i = 0; i < 4 * size; i++)
            {
                array[i] = Convert.ToChar(num.Next(65, 91));
            }
        }
        public void displayPage(int pageNumber, List<string> strList)
        {
            Console.WriteLine("Page {0}:", pageNumber);
            for (int i = 1; i <= 5; i++)
            {
                if (strList.Count >= pageNumber * 5)
                    Console.WriteLine("{0}: {1}", pageNumber * 5 - 5 + i, strList[pageNumber * 5 + i - 1 - 5]);
                else
                {
                    for (int j = pageNumber * 5 - 5; j <= strList.Count; j++)
                        Console.WriteLine("{0}: {1}", j, strList[j - 1]);
                    break;
                }

            }
        }
        public void removeTrash(List<string> strList)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                if (strList.Count > i + 1)
                {
                    if (strList[i] == strList[i + 1])
                    {
                        strList.Remove(strList[i + 1]);
                        i--;
                    }
                    if (strList[i].StartsWith("Z"))
                    {
                        strList.Remove(strList[i]);
                        i--;
                    }
                }
            }
        }
    }
}