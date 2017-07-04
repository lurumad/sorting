using System.Linq;
using FluentAssertions;
using Xunit;

namespace Sorts.Tests
{
    public class insertion_should
    {
        [Fact]
        public void sort_an_array_of_integers()
        {
            var orderedNumbers = new[] { 1, 2, 3, 4, 5, 6 };
            var unorderedNumbers = new[] {2, 3, 1, 4, 5, 6};
            var result = new Insertion().Sort(unorderedNumbers);
            orderedNumbers.SequenceEqual(result).Should().BeTrue();
        }
    }
}