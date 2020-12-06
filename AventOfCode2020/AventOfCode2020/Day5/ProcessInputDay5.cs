using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day5
{
    public class ProcessInputDay5
    {
        public static string ReadFile()
        {
            var input = File.ReadAllText(@"E:\Repo\AdventOfCode2020\AventOfCode2020\AventOfCode2020\Day5\InputDay5.txt");
            return input;
        }

        public static List<string> GetInput()
        {
            var input = ReadFile();
            var result = new List<string>();
            result = input.Split(new[] { '\n' }).ToList();
            return result;        
        }

    }
}
