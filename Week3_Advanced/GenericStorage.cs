// File: Week3_Advanced/GenericStorage.cs
// Purpose: Using Generics for Type-Safe data storage.

using System;
using System.Collections.Generic;

namespace Week3_Advanced
{
    // Generic Class 'T'
    public class DataBox<T>
    {
        private List<T> _items = new List<T>();

        public void Store(T item)
        {
            _items.Add(item);
            Console.WriteLine($"Successfully stored item of type: {typeof(T).Name}");
        }

        public List<T> RetrieveAll() => _items;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Box for Strings
            DataBox<string> stringBox = new DataBox<string>();
            stringBox.Store("Learning C# is fun");

            // Box for Integers
            DataBox<int> numberBox = new DataBox<int>();
            numberBox.Store(2026);

            Console.WriteLine("Generics implemented successfully.");
        }
    }
}