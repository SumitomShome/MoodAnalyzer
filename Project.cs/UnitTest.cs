using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
namespace ExceptionTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow ("I am in sad mood")]
        public void GivenSadMoodShow(string message)
        {
            string expected = "SAD";
            MoodAnalyse mood = new MoodAnalyse(message);
            var result = mood.analyseMood(message);
            Assert.AreEqual(expected, result);
        }
<<<<<<< HEAD
     }
=======
        [TestMethod]
        [DataRow(null)]
        public void GivenNullMoodShow(string message)
        {
            string expected = "HAPPY";
            MoodAnalyse mood = new MoodAnalyse(message);
            var result = mood.analyseMood(message);
            Assert.AreEqual(expected, result);
        }
    }
>>>>>>> UC2-NullException
}

