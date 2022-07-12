using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser
    {
        string mood;
        public Analyser(string mood)
        {
            this.mood = mood;
        }

        public string analyseMood()
        {
            try
            {
                if (this.mood.Equals(string.Empty))
                    throw new Analyser_Exception(Analyser_Exception.ExceptionType.EMPTY_MESSAGE, "Mood cannot be Empty");
                if (this.mood.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new Analyser_Exception(Analyser_Exception.ExceptionType.NULL_MESSAGE, "Mood is null");
            }
        }
    }
}
