using System;
namespace Sum
{
	public static class Sum
	{
		public static int Summator(int[] arr)
        {
            int sum = arr[0];
            for (int i = 1; i < arr
              .Length; i++)
                sum += arr[i];
            return sum;
        }
    }
}

