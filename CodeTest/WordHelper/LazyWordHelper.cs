using System;
using System.Linq;

namespace CodeTest.WordHelper
{
	public class LazyWordHelper : IWordHelper
	{
		public bool IsAnagram(string word1, string word2) => word1.ToLower().OrderBy(c => c).SequenceEqual(word2.ToLower().OrderBy(c => c));

		public bool IsPalindrome(string word) => word.ToLower().SequenceEqual(word.ToLower().Reverse());
	}
}
