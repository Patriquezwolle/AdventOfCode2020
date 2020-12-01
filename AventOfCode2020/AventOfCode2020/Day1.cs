using System;
using System.Collections.Generic;
using System.Text;

namespace AventOfCode2020
{
    class Day1
    {
        public static List<int> GetnumbersAssignment1()
        {
            List<int> result = new List<int>();
            result.Add(32);


            return result;


        }




        public static int CalculateNumbers(List<int> numbers)
        {
            foreach (var number1 in numbers)
            {
                foreach (var number2 in numbers)
                {
                    if (number1 + number2 == 2020)
                    {
                        Console.WriteLine($"Nummer1 = {number1}");
                        Console.WriteLine($"Nummer2 = {number2}");
                        var result = number1 * number2;
                        Console.WriteLine($"Resultaat = {result}");
                        return result;
                    }
                    return 0;
                }
                return 0;
            }
            return 0;
        }


    }
}

