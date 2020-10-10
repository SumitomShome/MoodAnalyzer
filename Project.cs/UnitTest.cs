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
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.analyseMoodLive();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message = "";
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.analyseMoodLive();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
    }
}
