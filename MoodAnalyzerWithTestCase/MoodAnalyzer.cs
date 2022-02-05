using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerWithTestCase
{/// <summary>
/// Mood Analyzer
/// </summary>
    public class MoodAnalyzer
    {
        public string Message;
        public string DisplayMoodAnalyzer(string message) //Creating a constructer 
        {
            Message = message;
            if (Message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "happy";
            }
        } 
    }
}
