/*
    Author: Kaitlyn Dunne
    Date: 09-27-2020
    Comments: Demonstrates the use of an array.
*/

using System;

namespace Dunne_TechAssignment3B
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                for (int i = 0; i <= 25; i++)
                {
                    Console.WriteLine("Element value = " + numbers[i]);
                }
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit the program..");
                Console.ReadKey(true);
            }

            catch
            {
                Console.WriteLine("Press any key to exit the program...");
                Console.ReadKey(true);
            }
        }
    }
}
