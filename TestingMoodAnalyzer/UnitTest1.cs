using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MoodAnalyzerWithTestCase;

namespace TestingMoodAnalyzer
{
    [TestClass]
    public class TestMothod1
    {
        [TestMethod]
        public void TestMethodMoodAnalyzer()
        {
            ///Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            MoodAnalyzer moodanalyzer = new MoodAnalyzer();//creating a object for a class
            //moodanalyzer.DisplayMoodAnalyzer(message);
            ///Act
            string actual = moodanalyzer.DisplayMoodAnalyzer(message);//hear we check the mood of user is happy or sad
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
