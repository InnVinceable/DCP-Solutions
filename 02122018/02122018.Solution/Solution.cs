using System;

namespace _02122018.Solution
{
    public class Solution
    {
        public static bool Solve(int k, int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = i; j < inputArray.Length; j++)
                {
                    var sum = inputArray[i] + inputArray[j];
                    if (sum == k) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
