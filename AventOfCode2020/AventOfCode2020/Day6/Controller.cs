using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2020.Day6
{
    public static class Controller
    {

        public static void GetResultAssignment1()
        {
            
            var input = ProcessInput.ReadfromFile();

            var answersbygroup = ProcessInput.GetAnswersByGroup(input);

            var nrAnswersGroup = Count.CountGroupAnwsers(answersbygroup);

            Console.WriteLine($"Day 6, assignment 1 resultaat = {nrAnswersGroup}");
        }

        public static void GetResultAssignment2()
        {
            var input = ProcessInput.ReadfromFile();
            var answersIndividual = ProcessInput.GetAnwsersByGroupIndividual(input);

            var answer = Count.CountIndividualGroup(answersIndividual);

            Console.WriteLine($"Day 6, assingment 2 resultaat = {answer}");
        }
    }
}
