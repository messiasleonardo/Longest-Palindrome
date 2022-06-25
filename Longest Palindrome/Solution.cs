namespace Longest_Palindrome
{
    public class Solution
    {
        public int LongestPalindrome(string s)
        {
			HashSet<char> part = new();
			int result = 0;
			for (int k = 0; k < s.Length; k++)
			{
				if (part.Contains(s[k]))
				{
					result += 2;
					part.Remove(s[k]);
				}
				else
				{
					part.Add(s[k]);
				}
			}
			if (part.Count != 0) result++;
			return result;
		}

        
    }
}