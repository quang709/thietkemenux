﻿using System;
using System.ComponentModel.Design;

namespace thietkemenu
{
    class Program
    {
        public static void Main()
        {
            int choice = 4;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                MenuCommand(choice);
            }
        }

        private static void MenuCommand(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Draw the triangle");
                    Console.WriteLine("******");
                    Console.WriteLine("*****");
                    Console.WriteLine("****");
                    Console.WriteLine("***");
                    Console.WriteLine("**");
                    Console.WriteLine("*");
                    break;
                case 2:
                    Console.WriteLine("Draw the square");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 3:
                    Console.WriteLine("Draw the rectangle");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    Console.WriteLine("* * * * * *");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("No choice!");
                    break;
            };
        }
    }
}
