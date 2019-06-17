using System;

namespace _03122018.Solution
{
    public class Solution
    {
        public static int[] Solve(int [] numbers) {
            int[] rtn = new int[numbers.Length];
            var productAll = 1;
            for (int i = 0 ; i < numbers.Length ; i++) {
                productAll = productAll * numbers[i];
            }
            for (int i = 0 ; i < numbers.Length ; i++) {
                rtn[i] = productAll * 1/numbers[i];
            }
            return rtn;
        }
    }
}
