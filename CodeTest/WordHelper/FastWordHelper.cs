using System;
using System.Linq;

namespace CodeTest.WordHelper
{
	public class FastWordHelper : IWordHelper
	{
		public bool IsAnagram(string word1, string word2)
		{
			if (word1.Length != word2.Length)
			{
				return false;
			}

			int matches = word2.Where(c => word1.Contains(c, StringComparison.OrdinalIgnoreCase)).Count();
			return matches == word1.Length;
		}

		public bool IsPalindrome(string word)
		{
			word = word.ToLower();
			int halfLength = word.Length / 2;
			for (int i = 0; i < halfLength; i++)
			{
				if (word[i] != word[word.Length - i - 1])
				{
					return false;
				}
			}
			return true;
		}
	}
}
