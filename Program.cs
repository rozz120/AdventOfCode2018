using System;
using System.Collections.Generic;

namespace Advent_of_code_2018
{
    class Program
    {
        static void Main(string[] args)
        {

            var dayOnePartOne = new DayOnePartOne();
            Console.WriteLine($"Day One, Part One Result: {dayOnePartOne.additionOfNumbers()}" );

            var dayOnePartTwo = new DayOnePartTwo();
            Console.WriteLine($"Day One, Part One Result: {dayOnePartTwo.firstReccuringNumber()}" );

            var dayTwoPartOne = new DayTwoPartOne();
            Console.WriteLine($"Day Two, Part One Result: {dayTwoPartOne.CheckBoxIdLetterCounts()}");

            var dayTwoPartTwo = new DayTwoPartTwo();
            Console.WriteLine($"Day Two, Part Two Result: {dayTwoPartTwo.DoPartTwo()}");
        }
    }
}
