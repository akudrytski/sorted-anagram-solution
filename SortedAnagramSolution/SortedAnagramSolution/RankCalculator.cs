using System;

namespace SortedAnagramSolution
{
    public class RankCalculator
    {
        private double CalculateRank(char[] sourceArray)
        {
            if (sourceArray.Length == 1) return 1;

            // n-2 iterations starting from 0 
            // -2, to skip the processing of the last element, which is not required
            var numberOfIterations = sourceArray.Length - 2;

            var result = 0d;
            for (var iterationIndex = 0; iterationIndex <= numberOfIterations; iterationIndex++)
            {
                var initialElement = sourceArray[iterationIndex];

                //sorted subset from the source array
                var sortedArray = new char[sourceArray.Length - iterationIndex];
                Array.Copy(sourceArray, iterationIndex, sortedArray, 0, sourceArray.Length - iterationIndex);
                Array.Sort(sortedArray);

                var indexInSortedArray = Array.IndexOf(sortedArray, initialElement);
                if (indexInSortedArray == 0) continue; // check if the element is on its "sorted" place

                // calculation of permutations required to place all lower elements on initial element's position
                var permutationsCount = 0d;
                for (var indexOfLeadingCharacterInSortedArray = 0; indexOfLeadingCharacterInSortedArray < indexInSortedArray; indexOfLeadingCharacterInSortedArray++)
                {
                    //check if permutations for this character have been already calculated (for repeated elements)
                    if (Array.IndexOf(sortedArray, sortedArray[indexOfLeadingCharacterInSortedArray]) < indexOfLeadingCharacterInSortedArray) continue; 

                    //subset of sorted array without first element, to calculate all possible permutations for lower element
                    var arrayToCalculatePermutations = new char[sortedArray.Length - 1];
                    Array.Copy(sortedArray, 1, arrayToCalculatePermutations, 0, sortedArray.Length - 1);
                    
                    if (indexOfLeadingCharacterInSortedArray > 0) //else array has been already populated as required
                    {
                        //making all elements except element at indexOfLeadingCharacterInSortedArray participate in permutations calculation
                        arrayToCalculatePermutations[indexOfLeadingCharacterInSortedArray - 1] = sortedArray[0];
                    }

                    permutationsCount += PermutationsHelper.GetPermutationsCount(arrayToCalculatePermutations);
                }

                result += permutationsCount;
            }

            return result + 1; // adding 1 because result actually represents the rank of the permutation before the source one
        }

        public double GetRank(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return 0;

            var charactersList = input.ToCharArray();

            return CalculateRank(charactersList);
        }
    }
}