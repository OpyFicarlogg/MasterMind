using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMind.Services;

namespace MasterMindTest
{
    [TestClass]
    public class SecretMatcherImplTest
    {
        readonly ISecretMatcher matcher = new SecretMatcherImpl();

        [TestMethod]
        public void TestTwoMatchOnePartial()
        {
            matcher.setSecret("1243");

            string ret = matcher.getMatch("1254");

            Assert.AreEqual("++-", ret);

        }

        [TestMethod]
        public void TestTwoMatchTwoPartial()
        {
            matcher.setSecret("1243");

            string ret = matcher.getMatch("2143");

            Assert.AreEqual("++--", ret);

        }


        [DataRow("7734", "1270")]
        [DataRow("1234", "2002")]
        [DataTestMethod]
        public void TestOnePartialPresentTwoTime(string secret, string input)
        {
            matcher.setSecret(secret);

            string ret = matcher.getMatch(input);

            Assert.AreEqual("-", ret);

        }


        [TestMethod]
        public void TestOneMatchNoPartial()
        {
            matcher.setSecret("1234");

            string ret = matcher.getMatch("2200");

            Assert.AreEqual("+", ret);

        }

        [TestMethod]
        public void TestOneMatchTwoPartial()
        {
            matcher.setSecret("3129");

            string ret = matcher.getMatch("1249");

            Assert.AreEqual("+--", ret);

        }

        [DataRow("1234", "1234")]
        [DataRow("2234", "2234")]
        [DataTestMethod]
        public void TestFullMatch(string secret, string input)
        {
            matcher.setSecret(secret);

            string ret = matcher.getMatch(input);

            Assert.AreEqual("++++", ret);

        }

    }
}
