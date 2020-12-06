using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Day1
{
    public static  class Day1
    {
        public static int CalculateNumbers2(List<int> numbers)
        {
            foreach (var number1 in numbers)
            {
                foreach (var number2 in numbers)
                {
                    foreach (var number3 in numbers)
                    {
                        if (number1 + number2 + number3 == 2020)
                        {
                            var result = number1 * number2 * number3;
                            return result;
                        }
                    }
                }
            }
            return 0;
        }

        public static int CalculateNumbers(List<int> numbers)
        {
            foreach (var number1 in numbers)
            {
                foreach (var number2 in numbers)
                {
                    if (number1 + number2 == 2020)
                    {
                        var result = number1 * number2;                      
                        return result;
                    }
                }
            }
            return 0;
        }


        public static void GetResultAssignment1()
        {
            var list = InputDay1.GetnumbersDay1();
            var result = CalculateNumbers(list);
            Console.WriteLine($"Day 1, Assignment 1 resultaat = {result}");
        }

        public static void GetResultAssingment2()
        {
            var list = InputDay1.GetnumbersDay1();
            var result = CalculateNumbers2(list);
            Console.WriteLine($"Day 1, Assignment 2 resultaat = {result}");
        }

    }
}

