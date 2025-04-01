namespace TrainingProgramming.LearningPathHomework2.namespaceC
{
    public class Chrome
    {
        private int WindowWidth_int { get; set; }
        private string WindowWidth_string { get; set; }
        private double WindowWidth_double { get; set; }

        public void SetWindowWidthInt(int value) => WindowWidth_int = value;
        public void SetWindowWidthString(string value) => WindowWidth_string = value;
        public void SetWindowWidthDouble(double value) => WindowWidth_double = value;

        //in Chrome class, add a method to do the following:
        //if WindowWidth_int is > 1920: to display window width, otherwise display a generic message e.g.
        //“window width less than 1920”.


        public void CheckWindowWidthInt()
        {
            if (WindowWidth_int >1920) {
                Console.WriteLine($"Window width is: {WindowWidth_int}");
            }else
                Console.WriteLine("Window width is less than 1920");
        }


    }
}
