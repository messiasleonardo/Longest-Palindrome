using Longest_Palindrome;
using Xunit;

namespace SolutionTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abccccdd", 7)]
        [InlineData("a", 1)]
        [InlineData("abb", 3)]
        [InlineData("abbb", 3)]
        [InlineData("bananas", 5)]
        [InlineData("aaabc", 3)]
        public void Test1(string s, int expected)
        {
            Solution solution = new Solution();

            int actual = solution.LongestPalindrome(s);

            Assert.Equal(expected, actual);
        }
    }
}