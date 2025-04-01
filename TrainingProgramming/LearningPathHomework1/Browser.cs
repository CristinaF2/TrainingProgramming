namespace TrainingProgramming.LearningPathHomework1
{
    public class Browser
    {
        public int WindowWidth;
        public int WindowHeight;

        public Browser( int windowWidth, int windowHeight)
        {
            WindowHeight = windowHeight;
            WindowWidth = windowWidth;
        }
        public void DisplayResolution()
        {
            Console.WriteLine($"The browser width is: {WindowWidth}");
            Console.WriteLine($"The browser height is: {WindowHeight}");

        }
        public int ChangeWindowWidth(int windowWidth)
        {
            WindowWidth= windowWidth;
            return WindowWidth;
        }
        public int ChangeWindowHeight(int windowHeight)
        {
            WindowHeight= windowHeight; 
            return WindowHeight;
        }

    }
}
