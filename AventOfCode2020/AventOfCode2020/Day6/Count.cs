using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day6
{
    public static class Count
    {
        public static int CountGroupAnwsers(List<string> groups)
        {
            int result = 0;
            foreach (var answers in groups)
            {
                var distinctAnswers = answers.ToCharArray().Distinct();
                result += (distinctAnswers.Count());
            }
            return result;
        }

        public static int CountIndividualGroup(List<List<string>> groupanswers)
        {
            int countPart2 = 0;
            foreach (List<string> answers in groupanswers)
            {
                int questionsCount = 0;
                foreach (char answer in answers[0])
                {
                    bool allAsked = true;
                    for (int i = 1; i < answers.Count; i++)
                    {
                        if (!answers[i].Contains(answer))
                        {
                            allAsked = false;
                            break;
                        }
                    }
                    if (allAsked)
                    {
                        questionsCount++;
                    }
                }
                countPart2 += questionsCount;
            }
            return countPart2;
        }
    }
}
