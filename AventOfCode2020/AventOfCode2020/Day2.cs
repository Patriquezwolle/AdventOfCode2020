using AventOfCode2020.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AventOfCode2020
{
    public class Day2
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
                var item = new PasswordList{
                MinCount = Int32.Parse(match.Groups[1].Value),
                MaxCount = Int32.Parse(match.Groups[2].Value),
                Charachter = match.Groups[3].Value,
                Password = match.Groups[4].Value              
                };
                items.Add(item);
            }

            return items;
        }
        

        public static List<PasswordList> GetInvalidPasswordList()
        {
            var fullList = RegTestLine();
            var result = new List<PasswordList>();
            foreach(var item in fullList)
            {
                char ch = item.Charachter.ToCharArray()[0];
                string passw = item.Password;
                int count = passw.Count(s => s == ch);
                var valid = GetValid(item, count);
                if (count >= item.MinCount && count <= item.MaxCount)
                {
                    var line = new PasswordList
                    {
                        MinCount = item.MinCount,
                        MaxCount = item.MaxCount,
                        Charachter = item.Charachter,
                        Password = item.Password
                    };
                    result.Add(line);
                }

                
                
                
            }
            return result;
        }

        public static void GetResult()
        {
            var result = GetInvalidPasswordList();
            foreach(var line in result)
            {
                var text = $" Min: {line.MinCount} Max: {line.MaxCount}  Char: {line.Charachter} Pass: {line.Password}";
                Console.WriteLine(text);
            }

            Console.WriteLine("Done");
        }

        private static string GetValid(PasswordList item, int count)
        {
            if (!(count <= item.MinCount) && !(count > item.MaxCount))
            {
                var valid = "Te weinig!";
                return valid; 
            }
            if (count > item.MaxCount)
            {
                var valid = "Te veel!";
                return valid;
            }
            else return "Valid!!";
        }




    }

    public class PasswordList
    {
        public int MinCount { get; set; }
        public int MaxCount { get; set; }
        public string Charachter {get;set;}
        public string Password { get; set; }


    }

    public class PasswordListValid
    {
        public int MinCount { get; set; }
        public int MaxCount { get; set; }
        public string Charachter { get; set; }
        public string Password { get; set; }
        public string Result { get; set; }
    }


}


