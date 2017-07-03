namespace Shorts
{
    public class Selection
    {
        public int[] Short(int [] numbers)
        {
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                var minimum = numbers[i];

                for (var j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[j] >= minimum)
                    {
                        continue;
                    }
                    var temporal = numbers[j];
                    numbers[j] = minimum;
                    numbers[i] = temporal;
                }
            }

            return numbers;
        }
    }
}