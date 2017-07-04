using System;

namespace Sorts
{
    public class Merge
    {
        public int[] Sort(int [] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            var leftLenght = numbers.Length / 2;
            var rightLength = numbers.Length - leftLenght;
            var left = Slice(numbers, 0, leftLenght);
            var right = Slice(numbers, leftLenght, rightLength);

            left = Sort(left);
            right = Sort(right);

            if (left[leftLenght - 1] >= right[0])
            {
                return MergeArrays(left, right);
            }

            var result = new int[left.Length + right.Length];
            Array.Copy(left, 0, result, 0, leftLenght);
            Array.Copy(right, 0, result, leftLenght, rightLength);
            return result;
        }

        private int[] Slice(int[] numbers, int index, int length)
        {
            var slice = new int [length];
            Array.Copy(numbers, index, slice, 0, length);
            return slice;
        }

        private int[] MergeArrays(int[] left, int[] right)
        {
            var result = new int [left.Length + right.Length];
            var leftIndex = 0;
            var rightIndex = 0;
            var totalIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    result[totalIndex] = left[leftIndex];
                    leftIndex++;
                    totalIndex++;
                }
                else
                {
                    result[totalIndex] = right[rightIndex];
                    rightIndex++;
                    totalIndex++;
                }
            }

            if (leftIndex < left.Length)
            {
                Array.Copy(left, leftIndex, result, totalIndex, left.Length - leftIndex);
            }

            if (rightIndex < right.Length)
            {
                Array.Copy(right, rightIndex, result, totalIndex, right.Length - rightIndex);
            }

            return result;
        }
    }
}