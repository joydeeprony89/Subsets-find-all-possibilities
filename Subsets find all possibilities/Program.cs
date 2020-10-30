using System;
using System.Collections;
using System.Collections.Generic;

namespace Subsets_find_all_possibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3 };
            var result = Subsets(nums);
            foreach (var res in result)
                Console.WriteLine(string.Join(" ", res));
        }

        static IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            result.Add(new List<int>());
            for (int j = 0; j < nums.Length;j++)
            {
                int length = result.Count;
                for (int i = 0; i < length; i++)
                {
                    List<int> innerResult = new List<int>();
                    innerResult.AddRange(result[i]);
                    innerResult.Add(nums[j]);
                    result.Add(innerResult);
                }
            }

            return result;
        }
    }
}
