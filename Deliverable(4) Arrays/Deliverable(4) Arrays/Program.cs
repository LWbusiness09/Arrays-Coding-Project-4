/*
  Author: Lucas Werneck
  Date: 02/02/2023
  Comments: This C# Console application code computes the first 25
            numbers of the Fibonacci sequence, where
            f (n) = f (n - 2) + f (n - 1)
*/

using System;

namespace Deliverable_4__Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] fibonacci = new int[25];

                // Initialize fibonacci series
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i < 25; i++)
                {
                   fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Fibonnaci number (" + i + ") = " + fibonacci[i]);
                }        
        }
    }
}