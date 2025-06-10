using TrainingProgramming.OOP;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public abstract class Dispozitiv
    {
        public string Nume { get; set; }
        public bool Pornit { get; set; }

        public Dispozitiv(string nume)
        {
            Nume = nume;
            Pornit = false;
        }

        public abstract void Porneste();
        public abstract void Opreste();

    }
}
