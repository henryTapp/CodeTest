using CodeTest.WordHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest.UnitTests
{
	[TestClass]
	public class FastWordHelperUnitTests
	{
		private static readonly IWordHelper _fastHelper = new FastWordHelper();

		[TestMethod]
		public void Test_IsPalindrome_DetectsTruePalindrome()
		{
			Assert.IsTrue(_fastHelper.IsPalindrome("Anna"));
		}

		[TestMethod]
		public void Test_IsPalindrome_DetectsFalsePalindrome()
		{
			Assert.IsTrue(!_fastHelper.IsPalindrome("Dormitory"));
		}

		[TestMethod]
		public void Test_IsAnagram_DetectsTrueAnagram()
		{
			Assert.IsTrue(_fastHelper.IsAnagram("Anna", "Nana"));
		}

		[TestMethod]
		public void Test_IsAnagram_DetectsFalseAnagram()
		{
			Assert.IsTrue(!_fastHelper.IsAnagram("Anna", "Dormitory"));
		}
	}
}
