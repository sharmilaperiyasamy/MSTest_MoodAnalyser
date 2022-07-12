using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyser_Exception : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        public ExceptionType Type;
        public Analyser_Exception(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}
