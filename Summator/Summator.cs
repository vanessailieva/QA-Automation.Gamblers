using System;
namespace Summator
{
    public static class Summator
    {
        public static int Sum(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr
              .Length; i++)
                sum += arr[i];
            return sum;
        }

        public static void Test_SumTwoNumbers()
        {

            if (Sum(new int[] { 1, 2 }) != 3)
                throw new Exception("1+2 != 3");
        }

    }
}


