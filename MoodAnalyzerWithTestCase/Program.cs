using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerWithTestCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Moodanalyzer with test case");
            MoodAnalyzer moodAnalyzer=new MoodAnalyzer(); //Creating object for a class
            moodAnalyzer.DisplayMoodAnalyzer("I am in Happy mood");
        }
    }
}
