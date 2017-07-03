namespace Shorts
{
    public class Insertion
    {
        public int[] Short(int [] numbers)
        {
            for (var i = 1; i < numbers.Length - 1; i++)
            {
                var j = i;
                while (j > 0 && numbers[j - 1] > numbers[j])
                {
                    var temporal = numbers[j];
                    numbers[j] = numbers[j - 1];
                    numbers[j - 1] = temporal;
                    j--;
                }
            }

            return numbers;
        }
    }
}