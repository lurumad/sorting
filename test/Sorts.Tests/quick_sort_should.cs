using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Sorts.Tests
{
    public class quick_sort_should
    {
        [Fact]
        public void sort_an_array_of_integers()
        {
            var unorderedNumbers = new[] { 2, 102, 2, 4, 45, 6, 100 };
            var orderedNumbers = new[] { 2, 2, 4, 6, 45, 100, 102 };
            new QuickSort<int>().Sort(unorderedNumbers);
            orderedNumbers.SequenceEqual(unorderedNumbers).Should().BeTrue();
        }

        [Fact]
        public void sort_users_by_name_with_custom_comparer()
        {
            var users = GivenAnUserList();

            var sortedNames = new[] { "Angel", "Esteban", "Pedro", "Zapatero" };

            new QuickSort<User>(new UserNameComparer()).Sort(users);

            sortedNames.SequenceEqual(users.Select(u => u.Name)).Should().BeTrue();

        }

        [Fact]
        public void sort_users_by_age_with_custom_comparer()
        {
            var users = GivenAnUserList();

            var sortedAges = new[] { 13, 20, 20, 45 };

            new QuickSort<User>(new UserAgeComparer()).Sort(users);

            sortedAges.SequenceEqual(users.Select(u => u.Age)).Should().BeTrue();

        }

        #region private
        private User[] GivenAnUserList()
        {
            return new[]
            {
                new User() {Name = "Angel", Age = 45},
                new User() {Name = "Pedro", Age = 20},
                new User() {Name = "Zapatero", Age = 13},
                new User() {Name = "Esteban", Age = 20}
            };
        }
        #endregion  
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class UserNameComparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return String.Compare(x.Name, y.Name, true);
        }
    }

    public class UserAgeComparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            if (x.Age == y.Age) return 0;
            return x.Age >= y.Age ? 1 : -1;
        }
    }

}
