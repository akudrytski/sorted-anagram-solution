using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace SortedAnagramSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter [a-z] string less or equal to 25 characters.");
            var initialSource = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(initialSource))
            {
                Console.WriteLine("String is empty.");
                Console.ReadKey();
                return;
            }

            if (initialSource.Length > 25)
            {
                Console.WriteLine("String is too long.");
                Console.ReadKey();
                return;
            }

            var source = initialSource.ToLower();
            if (!Regex.IsMatch(source, @"^[a-z]+$"))
            {
                Console.WriteLine("String contains invalid values.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Please select the number of times to execute the procedure.");
            var initialTimesToRun = Console.ReadLine();
            long timesToRun = 0;
            if (!long.TryParse(initialTimesToRun, out timesToRun))
            {
                Console.WriteLine("Invalid times to run number.");
                Console.ReadKey();
                return;
            }

            var stopWatch = new Stopwatch();

            var rankCalculator = new RankCalculator();
            var result = 0d;
            for (var index = 0L; index < timesToRun; index++)
            {
                stopWatch.Start();
                result = rankCalculator.GetRank(source);
                stopWatch.Stop();
            }

            Console.WriteLine("Source:{0}, Times executed:{1}, Average execution time(ms):{2}; Result:{3}", source,timesToRun, (double)stopWatch.ElapsedMilliseconds/timesToRun, result);
            Console.ReadKey();
        }
    }
}
