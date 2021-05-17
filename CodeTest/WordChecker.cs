using CodeTest.WordHelper;
using System;
using System.Collections.Generic;

namespace CodeTest
{
	class WordChecker
	{
		public static void CheckWords(IWordHelper helper, List<string> words)
		{
			words.ForEach(word1 => {

				IsAnagram(helper, word1, words);

				if (helper.IsPalindrome(word1) && Program.IsVerbose)
				{
					Console.WriteLine($"{word1} is a palindrome");
				}
			});
		}

		private static void IsAnagram(IWordHelper helper, string word1, List<string> words)
		{
			words.ForEach(word2 =>
			{
				if (word1 != word2)
				{
					if (helper.IsAnagram(word1, word2) && Program.IsVerbose)
					{
						Console.WriteLine($"{word1} is an anagram of {word2}");
					}
				}
			});
		}
	}
}
