using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Net50RegexSplitBug
{
    [TestClass]
    public class RegexSplitTests
    {
        [TestMethod]
        public void Test()
        {
            var result = Regex.Split("aabbccdd", @"(?<=\G..)(?=..)");

            var joined = string.Join("|", result); 

            Assert.AreEqual("aa|bb|cc|dd", joined);
        }
    }
}
