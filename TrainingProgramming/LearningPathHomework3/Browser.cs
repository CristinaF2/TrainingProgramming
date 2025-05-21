namespace TrainingProgramming.LearningPathHomework3
{
    public class Browser
    {
        public int WindowWidth_int;
        public string WindowWidth_string;

        //metodele virtuale pot fi suprascrise in clasele derivate dar nu TREBUIE fiindca au body

        public virtual void ChangeWindowWidth(int val)
        {
            WindowWidth_int = val;
            Console.WriteLine("Browser window width changed to: " + val);
        }
        public virtual void About()
        {
            Console.WriteLine("General info");

        }
    }
}
