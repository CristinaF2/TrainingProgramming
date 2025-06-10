namespace TrainingProgramming.Abstractizare.ClaseAbstracte
{
    public class Cerc : FormeGeometrice
    {
        public int Raza { get; set; }
        public override void CalculArie()
        {
            Console.WriteLine($"Aria cercului este egala cu: {Math.PI * Math.Pow(Raza,2)}");


        }
    }

}
