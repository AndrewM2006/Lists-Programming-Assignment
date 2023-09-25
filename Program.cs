using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string menuOption;
                Console.WriteLine("Press 1 for Integer List");
                Console.WriteLine("Press 2 for String List");
                Console.WriteLine("Press Q for Quit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    IntegerList();
                }
                else if (menuOption == "2")
                {
                    
                }
                else if (menuOption == "Q" || menuOption == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public static void IntegerList()
        {
            Random generator = new Random();
            List <int> numbers = new List<int>();
            for (int i = 0; i < 25; i++)
            {
                if (i < 24)
                {
                    numbers.Add(generator.Next(10, 21));
                    Console.Write(numbers[i] + ", ");
                }
                else
                {
                    numbers.Add(generator.Next(10, 21));
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
