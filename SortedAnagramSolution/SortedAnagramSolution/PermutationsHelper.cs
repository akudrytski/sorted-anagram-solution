using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedAnagramSolution
{
    public static class PermutationsHelper
    {
        public static double GetFactorial(int value)
        {
            if (value < 0) throw new ArgumentException("value");

            if (value <= 1) return 1;

            var result = 1d;

            for (var element = 1; element <= value; element++)
            {
                result *= element;
            }

            return result;
        }

        //result = n!/n1!*n2!*n3!...*nk! where n1+n2+n3+...+nk = n
        public static double GetPermutationsCount(char[] sourceArray)
        {
            if (sourceArray == null) throw new ArgumentException("sourceArray");

            if (sourceArray.Length == 0) return 0;
            if (sourceArray.Length == 1) return 1;

            var entiesArray = new int[char.MaxValue];
            foreach (var character in sourceArray)
            {
                entiesArray[character]++;
            }

            var dividend = GetFactorial(sourceArray.Length);  //n!
            var devisor = entiesArray
                .Where(x => x > 0)
                .Select(x => x)
                .Aggregate(1d, (current, next) => current * GetFactorial(next));  //n1!*n2!*n3!...*nk! where n1+n2+n3+...+nk = n

            return dividend / devisor;
        }
    }
}