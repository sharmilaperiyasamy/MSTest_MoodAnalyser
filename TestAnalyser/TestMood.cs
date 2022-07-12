namespace TestAnalyser
{
    public class Tests
    {
        [Test]
        public void Analyse_returnHappy()
        {
            string msg = "Iam in Happy Mood";
            MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser(msg);
            string mood = Message.analyseMood();
            Assert.AreEqual("Happy", mood);
        }
        [Test]
        public void Analyse_returnSad()
        {
            string msg = "Iam in Sad Mood";
            MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser(msg);
            string mood = Message.analyseMood();
            Assert.AreEqual("Sad", mood);
        }
        [Test]
        public void Analyse_nullreturnHappy()
        {
            try
            {
                string msg = null;
                MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser(msg);
                string mood = Message.analyseMood();
            }
            catch(MoodAnalyser.Analyser_Exception exp)
            {
                Assert.AreEqual("Mood is null", exp.Message);
            }
        }
        [Test]
        public void Analyse_EmptyreturnHappy()
        {
            try
            {
                string msg = "";
                MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser(msg);
                string mood = Message.analyseMood();
            }
            catch (MoodAnalyser.Analyser_Exception exp)
            {
                Assert.AreEqual("Mood cannot be Empty", exp.Message);
            }
        }
    }
}