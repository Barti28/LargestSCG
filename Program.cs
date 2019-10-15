using System;

namespace LargestSCG
{
    class Program
    {
       public static void Main(string[] args)
        {
            int[] v = { 12, -34, 40, 6, -10, 56, 12, -1, -15, 10, 4 };//example vector declaration
            int vlength = v.Length; //the length of the vector
            maxSubArraySum(v, vlength);// calling the method 
        }
        static void maxSubArraySum(int[] vector,
                               int size)
        {
            int max = int.MinValue,
            max_end = 0, start = 0,
            end = 0, snew = 0; //max is maximum sum of the vector and in the beginning it has the min value, start is start index, end is end index and snew is a variable that holds temporary position of start variable, maxend is a temporary  variable that holds maximum and we made the control for maxend

            for (int i = 0; i < size; i++)
            {
                max_end += vector[i];

                if (max < max_end)
                {
                    max = max_end;
                    start = snew;
                    end = i;
                }

                if (max_end < 0)
                {
                    max_end = 0;
                    snew = i + 1;
                }
            }
            Console.WriteLine("Maximum contiguous " +
                             "sum is " + max);
            Console.WriteLine("Starting index " +
                                          start);
            Console.WriteLine("Ending index " +
                                          end);
        }

    }
}
