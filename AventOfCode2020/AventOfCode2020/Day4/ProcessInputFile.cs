using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day4
{
    public class ProcessInputFile
    {


        public static string ReadfromFile()
        {
            var input = File.ReadAllText(@"E:\Repo\AdventOfCode2020\AventOfCode2020\AventOfCode2020\Day4\Day4.txt");
            return input;
        }

        public static List<string>TransformToList()
        {
            var result = new List<string>();
            var input = ReadfromFile();
            result = input.Split(new[] { '\n' }).ToList();
            return result;
        }

        public static IEnumerable<string>ParseValues(string input)
        {
            var result = input.Split(" ");
            return result;
        }

        public static IEnumerable<IEnumerable<string>> GetPassports()
        {
            var passports = File.ReadAllText(@"E:\Repo\AdventOfCode2020\AventOfCode2020\AventOfCode2020\Day4\Day4.txt")
    .Split("\r\n\r\n")
    .Select(x => x.Replace(System.Environment.NewLine, " "))
    .Select(ParseValues);

            return passports;
        }

        
    }
}
