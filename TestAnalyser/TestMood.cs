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
    }
}