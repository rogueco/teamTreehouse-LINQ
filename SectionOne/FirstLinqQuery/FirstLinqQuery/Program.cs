using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstLinqQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var numbers = new List<int> { 2, 4, 7, 16, 32, 64 };

            Console.WriteLine($"A full list of numbers are: {numbers}");


            var numbersGreaterThanTen = new List<int>();

            foreach(int number in numbers)
            {
                if (number > 10)
                {
                    numbersGreaterThanTen.Add(number);
                    Console.WriteLine($"All the numbers which are greater than ten are: {number} ");
                }
            }



            var q = from number in numbers where number > 10 select number; 

            foreach (int item in numbers) 
            { 
                Console.WriteLine(item.ToString()); 
            }
        }
    }
}
