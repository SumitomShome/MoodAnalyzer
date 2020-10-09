using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
namespace ExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenSadMoodShow()
        {
            string expected = "SAD";
            string message = "I am in sad mood";
            MoodAnalyse mood = new MoodAnalyse(message);
            var result = mood.analyseMood(message);
            Assert.AreEqual(expected, result);
        }
     }
}
