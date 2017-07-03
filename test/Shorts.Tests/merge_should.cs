using System.Linq;
using FluentAssertions;
using Xunit;

namespace Shorts.Tests
{
    public class merge_should
    {
        [Fact]
        public void short_an_array_of_integers()
        {
            var orderedNumbers = new[] { 1, 2, 3, 4, 5, 6 };
            var unorderedNumbers = new[] {2, 5, 4, 6, 3, 1};
            var result = new Merge().Short(unorderedNumbers);
            orderedNumbers.SequenceEqual(result).Should().BeTrue();
        }
    }
}