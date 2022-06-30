using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringTesting
{
    [TestClass]
    public class StringTesting
    {
        [TestMethod]
        public void Reverse_ReverseWordCorrectly()
        {
            Assert.AreEqual("drow", StringUtils.StringUtils.Reverse("word"));
        }

        [TestMethod]
        public void Reverse_EmptyStringException()
        {
            
        }


    }
}
