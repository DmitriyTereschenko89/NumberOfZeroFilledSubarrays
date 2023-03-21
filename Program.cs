namespace NumberOfZeroFilledSubarrays
{
    internal class Program
    {
        public class NumberZeroFilledSubarrays
        {
            public long ZeroFilledSubarray(int[] nums)
            {
                //long result = 0;
                //long countZeroes = 0;
                //for (int i = 0; i < nums.Length;)
                //{
                //    if (nums[i] != 0)
                //    {
                //        ++i;
                //        continue;
                //    }
                //    else
                //    {
                //        while (i < nums.Length && nums[i] == 0)
                //        {
                //            ++i;
                //            ++countZeroes;
                //            result += countZeroes;
                //        }
                //        countZeroes = 0;
                //    }
                //}
                //return result;
                long result = 0;
                long countZeroes = 0;
                for (int i = 0; i < nums.Length; ++i)
                {
                    if (nums[i] != 0)
                    {
                        countZeroes = 0;
                    }
                    else
                    {
                        ++countZeroes;
                    }
                    result += countZeroes;
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            NumberZeroFilledSubarrays numberZeroFilledSubarrays = new();
            Console.WriteLine(numberZeroFilledSubarrays.ZeroFilledSubarray(new int[] { 1, 3, 0, 0, 2, 0, 0, 4 }));
            Console.WriteLine(numberZeroFilledSubarrays.ZeroFilledSubarray(new int[] { 0, 0, 0, 2, 0, 0 }));
            Console.WriteLine(numberZeroFilledSubarrays.ZeroFilledSubarray(new int[] { 2, 10, 2019 }));
        }
    }
}