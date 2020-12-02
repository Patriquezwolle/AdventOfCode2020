using AventOfCode2020.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day2
{
    public static class ProcessInput
    {
        public static List<string> GetInputSplitted()
        {
            var input = InputDay2.GetInput();
            var result = new List<string>();
            result = input.Split(new[] { '\n' }).ToList();
            return result;

        }

        public static List<PasswordList> RegTestLine()
        {
            var input = GetInputSplitted();
            var items = new List<PasswordList>();
            foreach (var line in input)
            {
                Regex regex = new Regex(@"^(\d+)-(\d+)\s([a-z|A-Z]):\s(.*?)$");
                Match match = regex.Match(line);
                var item = new PasswordList
                {
                    MinCount = Int32.Parse(match.Groups[1].Value),
                    MaxCount = Int32.Parse(match.Groups[2].Value),
                    Charachter = match.Groups[3].Value,
                    Password = match.Groups[4].Value
                };
                items.Add(item);
            }

            return items;
        }

    }
}
