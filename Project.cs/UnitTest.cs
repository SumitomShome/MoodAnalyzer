using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
namespace MoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyse", "MoodAnalyse");
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            object expected = new MoodAnalyse("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "SAD");
            expected.Equals(obj);
        }
    }
}
