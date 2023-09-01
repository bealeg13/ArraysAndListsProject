using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //* Create two Lists of type int.
            // * Name one List "evens"
            List<int> evens = new List<int>();
             
            // * Name the other List "odds"
            List<int> odds = new List<int>();
             
            // */

            //* Using either a foreach or for loop,
            // * nest an if statement to check to see
            // *  if a number is even or odd.
            // * Then add those numbers to either the evens List
            // * or the odds List
            // */
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }



            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (int number in evens)
            {
                Console.WriteLine($"The number {number} is even");
            }
            foreach(int number in odds)
            {
                Console.WriteLine($"The number {number} is odd");
            }


        }

    }
}
