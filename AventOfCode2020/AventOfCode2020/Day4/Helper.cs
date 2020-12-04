using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Day4
{
    public static class Helper
    {
        public static bool StringIsIntInRange(string input, int min, int max)
        {
            if (input == null)
            {
                return false;
            }

            try
            {
                int value = Int32.Parse(input);
                if (min > value || value > max)
                {
                    return false;
                }

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
