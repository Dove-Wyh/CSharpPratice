using System;
using System.Collections.Generic;

namespace Leetcode448_找到所有数组中消失的数字
{
    class Program
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            IList<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }

        public static IList<int> FindDisappearedNumbers2(int[] nums)
        {
            IList<int> list = new List<int>();
            HashSet<int> set = new HashSet<int>(nums);
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                    list.Add(i);
            }
            return list;
        }

        public static IList<int> FindDisappearedNumberAndAppearedNumber(int[] nums)
        {
            IList<int> list = new List<int>();
            //先寻找不存在的数字
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    list.Add(i + 1);
                }
            }
            //再寻找重复的数字
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                nums[index] = -nums[index];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    list.Add(i + 1);
                }
            }
            return list;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IList<int> result1 = FindDisappearedNumbers(new int[] { 1, 2, 6, 7, 7, 8, 4, 9, 9 });
            IList<int> result2 = FindDisappearedNumberAndAppearedNumber(new int[] { 1, 2, 6, 7, 7, 8, 4, 3, 5 });
        }
    }
}
