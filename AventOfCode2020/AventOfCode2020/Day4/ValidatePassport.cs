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
            Console.WriteLine(part1);
            var i = 1;
            //237
        }

        public static void ValidateAssignment2()
        {
            var input = ProcessInputFile.GetPassports();
            var part2 = input.Where(Validations.HasAllElements).Where(ValidValues)
                .Count();
            Console.WriteLine(part2);
            var i = 1;
            //172

        }

        public static bool ValidValues(IEnumerable<string> values)
        {
            return values.All(Validations.ValidValue);
        }
    }
}
