namespace TrainingProgramming.LearningPathHomework3
{
    public class InternetExplorer : Browser
    {
        public override void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine("Internet Explorer window width changed to: " + val);
        }
    }
}
