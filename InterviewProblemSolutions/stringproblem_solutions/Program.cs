using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringproblem_solutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            int[] output = prog.TwoSum();
            Console.ReadKey();
        }

        public int[] TwoSum()
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] output = { 0, 0 };
            for (int i = 0; i <= nums.Length - 2; i++)
            {
                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output = new int[] { i, j };
                        return output;
                    }
                }
            }
            return output;
        }
    }
}
