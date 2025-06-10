namespace TrainingProgramming.Abstractizare.TestingMultipleBrowsers
{
    public abstract class Browser
    {
        public string Nume { get; set; }
        public bool Deschis { get; set; }

        public Browser(string nume)
        {
            Nume = nume;
            Deschis = false;
        }

        public abstract void Deschide();
        public abstract void Inchide();
    }
}
