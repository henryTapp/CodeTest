using CodeTest.WordHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeTest.UnitTests
{
	[TestClass]
	public class LazyWordHelperUnitTests
	{ 
		private static readonly IWordHelper _lazyHelper = new LazyWordHelper();

		[TestMethod]
		public void Test_IsPalindrome_DetectsTruePalindrome()
		{
			Assert.IsTrue(_lazyHelper.IsPalindrome("Anna"));
		}

		[TestMethod]
		public void Test_IsPalindrome_DetectsFalsePalindrome()
		{
			Assert.IsTrue(!_lazyHelper.IsPalindrome("Dormitory"));
		}

		[TestMethod]
		public void Test_IsAnagram_DetectsTrueAnagram()
		{
			Assert.IsTrue(_lazyHelper.IsAnagram("Anna", "Nana"));
		}

		[TestMethod]
		public void Test_IsAnagram_DetectsFalseAnagram()
		{
			Assert.IsTrue(!_lazyHelper.IsAnagram("Anna", "Dormitory"));
		}
	}
}
