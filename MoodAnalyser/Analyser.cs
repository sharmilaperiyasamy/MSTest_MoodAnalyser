using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
        public string analyseMood(string mood)
        {
            if (mood.Contains("Sad"))
                return "Sad";
            else
                return "Happy";

        }
    }
}
