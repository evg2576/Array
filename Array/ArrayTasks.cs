using System;
using System.Linq;

namespace ArrayObject
{
    public static class ArrayTasks
    {
        /// <summary>
        /// Task 1
        /// </summary>
        public static void ChangeElementsInArray(int[] nums)
        {
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[nums.Length - i - 1] % 2 == 0)
                {
                    nums[i] = nums[i] + nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = nums[i] - nums[nums.Length - i - 1];
                    nums[i] = nums[i] - nums[nums.Length - i - 1];
                }
            }
        }

        /// <summary>
        /// Task 2
        /// </summary>
        public static int DistanceBetweenFirstAndLastOccurrenceOfMaxValue(int[] nums)
        {
            int maxIndex = 0, minIndex = 0;
            int maxInt = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= maxInt)
                {
                    maxInt = nums[i];
                    maxIndex = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == maxInt)
                {
                    minIndex = i;
                    break;
                }
            }
            return maxIndex - minIndex;
        }

        /// <summary>
        /// Task 3 
        /// </summary>
        private static void ChangeMatrixDiagonally(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i > j) matrix[i, j] = 0; 
                    else if (i < j) matrix[i, j] = 1;
                }
            }
        }
    }
}
