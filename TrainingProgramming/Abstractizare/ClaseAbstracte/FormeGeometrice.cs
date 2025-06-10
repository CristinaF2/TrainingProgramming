namespace TrainingProgramming.Abstractizare.ClaseAbstracte
{
    public abstract class FormeGeometrice
    {
        public string Culoare { get; set; }
        
        public abstract void CalculArie();

        public void Deseneaza()
        {
            Console.WriteLine($"Deseneaza forma geometrica");
        }

    }
}
