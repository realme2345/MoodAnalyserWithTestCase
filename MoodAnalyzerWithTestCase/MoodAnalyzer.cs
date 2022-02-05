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
        public MoodAnalyzer(string message) //Creating a constructer 
        {
            this.Message = message;
        }
        public string AnalyseMethod()   //hear we check the mood of user is happy or sad
        {
            if (Message.ToLower().Contains("happy"))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
        } 
    }
}
