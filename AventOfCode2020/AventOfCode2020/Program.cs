using System;

namespace AventOfCode2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Day1.GetnumbersAssignment1();
            var result = Day1.CalculateNumbers(list);
            Console.WriteLine($"Totaal resultaat = {result}");
        }
    }
}
