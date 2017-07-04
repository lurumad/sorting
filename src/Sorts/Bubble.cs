using System;

namespace Sorts
{
    public class Bubble
    {
        private int swap = -1;

        public int[] Sort(int [] numbers)
        {
            do
            {
                swap = 0;

                for (var i = 0; i < numbers.Length-1; i++)
                {
                    if (numbers[i] <= numbers[i + 1])
                    {
                        continue;
                    }
                    var temporal = numbers[i];
                    numbers[i] = numbers[i+1];
                    numbers[i + 1] = temporal;
                    swap++;
                }

            } while (swap > 0);

            return numbers;
        }
    }
}