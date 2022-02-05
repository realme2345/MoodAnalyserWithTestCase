using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerWithTestCase
{/// <summary>
/// Mood Analyzer
/// </summary>
    class MoodAnalyzer
    {
        public string Message;
        public void DisplayMoodAnalyzer(string message) //Creating a constructer 
        {
            Message = message;
            if (Message.ToLower().Contains("happy"))
            {
               Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Sad");
            }
        } 
    }
}
