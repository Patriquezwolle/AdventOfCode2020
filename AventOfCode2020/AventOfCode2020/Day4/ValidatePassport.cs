using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day4
{

    public class ValidatePassport
    {

        public static void ValidateAssignment1()
        {
            var input = ProcessInputFile.GetPassports();
            var part1 = input.Where(Validations.HasAllElements).Count();
            Console.WriteLine($"Day 4, assignment 1 resultaat = {part1}");
            //237
        }

        public static void ValidateAssignment2()
        {
            var input = ProcessInputFile.GetPassports();
            var part2 = input.Where(Validations.HasAllElements).Where(ValidValues)
                .Count();
            Console.WriteLine($" Day 4, assignment 2 resultaat = {part2}");
            //172

        }

        public static bool ValidValues(IEnumerable<string> values)
        {
            return values.All(Validations.ValidValue);
        }
    }
}
