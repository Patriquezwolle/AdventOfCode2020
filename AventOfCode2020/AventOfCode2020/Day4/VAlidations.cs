using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2020.Day4
{
    public static class Validations
    {
        public static bool HasAllElements(IEnumerable<string> values)
        {
            var validValues = new string[] { "byr:", "iyr:", "eyr:", "hgt:", "hcl:", "ecl:", "pid:" }
            .All(start => values.Any(x => x.StartsWith(start)));
            return validValues;
        }

        public static bool ValidValue(string value)
        {
            var part = value.Substring(0, 3);
            switch (part)
            {
                case "byr":
                    var regex = new Regex("^byr:(19[2-9][0-9]|200[0-2])$");
                    if (regex.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "iyr":
                    var regex2 = new Regex("^iyr:(201[0-9]|2020)$");
                    if (regex2.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "eyr":
                    var regex3 = new Regex("^eyr:(202[0-9]|2030)$");
                    if (regex3.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "hgt":
                    var regex4 = new Regex("^hgt:(1([5-8][0-9]|9[0-3])cm|(59|6[0-9]|7[0-6])in)$");
                    if (regex4.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "hcl":
                    var regex5 = new Regex("^hcl:#[a-f0-9]{6}$");
                    if (regex5.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "ecl":
                    var regex6 = new Regex("^ecl:(amb|blu|brn|gry|grn|hzl|oth)$");
                    if (regex6.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                case "pid":
                    var regex7 = new Regex("^pid:[0-9]{9}$");
                    if (regex7.IsMatch(value))
                    {
                        return true;
                    }
                    return false;
                default:
                    return true;
            }
        }


    }
}
