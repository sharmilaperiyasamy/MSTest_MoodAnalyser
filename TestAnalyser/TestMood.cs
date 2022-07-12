namespace TestAnalyser
{
    public class Tests
    {
        [Test]
        public void Analyse_returnHappy()
        {
            MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser();
            string mood = Message.analyseMood("Iam in Happy Mood");
            Assert.AreEqual("Happy", mood);
        }
        [Test]
        public void Analyse_returnSad()
        {
            MoodAnalyser.Analyser Message = new MoodAnalyser.Analyser();
            string mood = Message.analyseMood("Iam in Sad Mood");
            Assert.AreEqual("Sad", mood);
        }
    }
}