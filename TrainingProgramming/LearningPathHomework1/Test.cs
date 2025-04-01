namespace TrainingProgramming.LearningPathHomework1
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            Browser browser = new Browser(200, 300);
            browser.ChangeWindowHeight(1080);
            browser.ChangeWindowWidth(1920);
            browser.DisplayResolution();
        }

    }
}
