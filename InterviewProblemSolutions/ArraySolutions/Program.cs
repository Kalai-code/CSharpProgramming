using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            int num = prog.MaxSubArray();
            Console.WriteLine(num);
            Console.ReadKey();
        }
        public int MaxSubArray()
        {
            int[] nums = { -2, 1 };
            int Maxsum = nums.Max();
            int iSum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                iSum = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    iSum = iSum + nums[j];
                    if (iSum > Maxsum)
                    {
                        Maxsum = iSum;
                    }
                }
            }
            return Maxsum;
        }
    }
}
