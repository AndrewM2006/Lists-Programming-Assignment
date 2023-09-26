﻿using System;
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
            bool exit = false, valid;
            int listlength=0, remove=0;
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
            while (!exit)
            {
                string menuOption;
                Console.WriteLine("1: Sort the List");
                Console.WriteLine("2: Make a New List of Random Numbers");
                Console.WriteLine("3: Remove a Number (by Value)");
                Console.WriteLine("4: Add a Value to the List");
                Console.WriteLine("5: Count the Number of Occurrences of a Specified Number");
                Console.WriteLine("6: Print the Largest Value");
                Console.WriteLine("7: Print the Smallest Value");
                Console.WriteLine("8: Print the Sum and Average of the Numbers in the List");
                Console.WriteLine("9: Determine the Most Frequently Occurring Value(s)");
                Console.WriteLine("10:Specify a Value and Find the Number of Occurrences of that Value in the List.");
                Console.WriteLine("Press E to Exit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    numbers.Sort();
                    listlength = 0;
                    foreach (int number in numbers)
                    {
                        listlength++;
                        if (listlength < numbers.Count)
                        {
                            Console.Write(number + ", ");
                        }
                        else
                        {
                            Console.WriteLine(number);
                        }
                    }
                }
                else if (menuOption == "2")
                {
                    numbers.Clear();
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
                else if (menuOption == "3")
                {
                    valid = false;
                    Console.Write("What Number Should be Removed: ");
                    while (!valid)
                    {
                        if (int.TryParse(Console.ReadLine(), out remove)&&numbers.Contains(remove))
                        {
                            valid=true;
                        }
                        else
                        {
                            Console.WriteLine("Enter a Valid Number");
                            Console.Write("What Number Should be Removed: ");
                        }
                    }
                    valid = false;
                    foreach (int number in numbers.ToList())
                    {
                        if (number == remove)
                        {
                            numbers.Remove(remove);
                        }
                    }
                    listlength = 0;
                    foreach (int number in numbers)
                    {
                        listlength++;
                        if (listlength < numbers.Count)
                        {
                            Console.Write(number + ", ");
                        }
                        else
                        {
                            Console.WriteLine(number);
                        }
                    }
                }
                else if (menuOption == "4")
                {
                    
                }
                else if (menuOption == "5")
                {
                    
                }
                else if (menuOption == "6")
                {
                    
                }
                else if (menuOption == "7")
                {
                    
                }
                else if (menuOption == "8")
                {
                    
                }
                else if (menuOption == "9")
                {
                    
                }
                else if (menuOption == "10")
                {
                    
                }
                else if (menuOption == "E" || menuOption == "e")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
