using System;
using System.Collections.Generic;

namespace Advent_of_code_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayTwoPartOne = new DayTwoPartOne();
            Console.WriteLine($"Day Two, Part One Result: {dayTwoPartOne.CheckBoxIdLetterCounts()}");

            var dayTwoPartTwo = new DayTwoPartTwo();
            Console.WriteLine($"Day Two, Part Two Result: {dayTwoPartTwo.DoPartTwo()}");
        }
    }
}
