using AventOfCode2020.Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day2
{
    public class Day2
    {
        public static void GetResultCount()
        {
            var result = GetValidPasswordList();
            Console.WriteLine(result.Count());
            Console.WriteLine("Done");
        }

        private static List<PasswordList> GetValidPasswordList()
        {
            var fullList = ProcessInput.RegTestLine();
            var result = new List<PasswordList>();
            foreach(var item in fullList)
            {
                char ch = item.Charachter.ToCharArray()[0];
                string passw = item.Password;
                int count = passw.Count(s => s == ch);
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

        public static void GetResultPositions()
        {
            var result = GetInvalidPasswordListPosition();
            Console.WriteLine(result.Count());
            Console.WriteLine("Done");
        }

        private static List<PasswordList>GetInvalidPasswordListPosition()
        {
            var fullList = ProcessInput.RegTestLine();
            var result = new List<PasswordList>();
            foreach(var item in fullList)
            {
                char ch = item.Charachter.ToCharArray()[0];
                string passw = item.Password;
                char firstChar = passw[item.MinCount - 1];
                char secondChar = passw[item.MaxCount - 1];
                if ((firstChar == ch && secondChar != ch) || (firstChar != ch && secondChar == ch))
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

        




    }

   
}


