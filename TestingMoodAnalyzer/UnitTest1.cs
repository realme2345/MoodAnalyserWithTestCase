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
            string message = "I am in happy mood";
            string expected = "sad";
            MoodAnalyzer moodanalyzer = new MoodAnalyzer(message);//creating a object for a class
            ///Act
            string actual = moodanalyzer.AnalyseMethod();//hear we check the mood of user is happy or sad
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
