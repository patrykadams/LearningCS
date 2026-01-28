// File: Week1_Fundamentals/Program.cs
// Purpose: Demonstrating basic types, control flow, and stack vs heap.

using System;

namespace Week1_Fundamentals
{
    class First
    {
        static void Main(string[] args)
        {
            // Value types (Stack)
            int age = 25;
            double price = 19.99;
            bool isReady = true;

            // Reference types (Heap)
            string message = "Welcome to C# Masterclass";

            Console.WriteLine($"--- Week 1: {message} ---");

            // Basic Control Flow
            if (age >= 18)
            {
                Console.WriteLine($"Age {age}: Access Granted.");
            }

            // Loop demonstration
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Iteration: {i}");
            }
        }
    }
}