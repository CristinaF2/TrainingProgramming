namespace TrainingProgramming.LearningPathHomework2.namespaceD
{
    public class InternetExplorer
    {
        private int WindowWidth_int { get; set; }
        private string WindowWidth_string { get; set; }
        private double WindowWidth_double { get; set; }

        public void SetWindowWidthInt(int value) => WindowWidth_int = value;
        public void SetWindowWidthString(string value) => WindowWidth_string = value;
        public void SetWindowWidthDouble(double value) => WindowWidth_double = value;


        public void CheckWindowWidthInt()
        {
            int j = 0;
            if (WindowWidth_int >1920)
            {
               while (j<=2)
                {
                    Console.WriteLine($"Window width is: {WindowWidth_int}");
                    j++;
                }
            }
            else
                for (int i = 0; i<=1; i++)
                {
                    Console.WriteLine($"Window width is: {WindowWidth_int}");
                }
           
        }
    }
}
