using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day6
{
    public static class ProcessInput
    {
        public static string[] ReadfromFile()
        {
             string[] input = File.ReadAllLines(@"E:\Repo\AdventOfCode2020\AventOfCode2020\AventOfCode2020\Day6\InputDay6.txt");
            return input;
        }

        public static List<string>GetAnswersByGroup(string[] input)
        {
            var result = new List<string>();
            var groupCombine = new StringBuilder();
            int maxLines = input.Count()-1;
            int count = 0;

            foreach (var line in input)
            {
                if (line != "")
                {
                    //Geen lege regel
                    groupCombine.Append(line + " ");

                    //Bij laatste regel moet de groep toegevoegd worden.
                    if (count == maxLines)
                    {
                        groupCombine.Replace(" ", "");
                        result.Add(groupCombine.ToString());
                        groupCombine.Clear();
                    }
                }
                if (line == "")
                {
                    //Lege regel, dus einde groep
                    groupCombine.Replace(" ", "");
                    result.Add(groupCombine.ToString());
                    groupCombine.Clear();
                }
                count++;
            }
            return result;
        }

        public static List<List<string>>GetAnwsersByGroupIndividual(string[] input)
        {
            var result = new List<List<string>>();
            var temp = new List<string>();
            int maxLines = input.Count() - 1;
            int count = 0;

            foreach (var line in input)
            {
                if(line != "")
                {
                    //Geen lege regel, dus antwoorden.
                    temp.Add(line);
                    //Bij laatste regel moet de groep toegevoegd worden.
                    if (count == maxLines)
                    {
                        result.Add(temp);
                    }
                }
                if (line == "")
                {
                    //Lege regel, einde van de groep
                    result.Add(temp);
                    //temp weer opschonen voor volgende loop.
                    temp = new List<string>();
                }
                count++;
            }
            return result;
        }
    }
}
