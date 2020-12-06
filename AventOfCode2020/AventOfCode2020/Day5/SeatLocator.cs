using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2020.Day5
{
    public static class SeatLocator
    {
        public static int GetRowNr(string charachters)
        {
            var chHigh = "B".ToCharArray()[0];
            var chLow = "F".ToCharArray()[0];
            var ch = charachters.ToCharArray();
            var first = ch[0];
            var second = ch[1];
            var third = ch[2];
            var fourth = ch[3];
            var fifth = ch[4];
            var sixth = ch[5];
            var seventh = ch[6];
            int high = 127;
            int low = 0;

            if (first == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (first == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (second == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (second == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (third == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (third == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (fourth == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (fourth == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (fifth == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (fifth == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (sixth == chHigh)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                low = low + diff;
            }
            if (sixth == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (seventh == chHigh)
            {
                return high;
            }
            if (seventh == chLow)
            {
                return low;
            }

            return 0;
        }



        public static int GetColumnNr(string characters)
        {
            var ch = characters.ToCharArray();
            char chHigh = "R".ToCharArray()[0];
            var chLow = "L".ToCharArray()[0];
            var first = ch[7];
            var second = ch[8];
            var third = ch[9];
            int high = 7;
            int low = 0;
            
            if (first == chHigh)
            {
                low = (int)Math.Ceiling((double)high / 2);
            }
            if(first == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff / 2);
                high = high - diff;
            }
            if (second == chHigh)
            {
                low = (int)Math.Ceiling((double)high / 2);
            }
            if (second == chLow)
            {
                var diff = (high - low);
                diff = (int)Math.Ceiling((double)diff/2);
                high = high - diff;
            }
            if(third == chHigh)
            {
                return high;
            }
            if(third == chLow)
            {
                return low;
            }
            return 0;
        }

        




        public static int GetSeatId(int row, int column)
        {
            var seatId = row * 8;
            seatId = seatId + column;
            return seatId;
        }

    }
}
