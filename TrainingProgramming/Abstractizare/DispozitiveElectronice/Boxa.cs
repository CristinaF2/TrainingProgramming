using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class Boxa : Dispozitiv, IAreVolum, IPeriferic
    {
        private int Volum { get; set; }
        public Boxa(string nume, int volum) : base(nume)
        {
            Volum = volum;
        }

        public override void Porneste()
        {
            if (Pornit)
                Console.WriteLine($"Boxa {Nume} este deja pornită.");
            else
            {
                Pornit = true;
                Console.WriteLine($"Boxa {Nume} a fost pornită.");
            }
        }

        public override void Opreste()
        {
            if (!Pornit)
                Console.WriteLine($"Boxa {Nume} este deja oprită.");
            else
            {
                Pornit = false;
                Console.WriteLine($"Boxa {Nume} a fost oprită.");
            }
        }

        public void CresteVolum()
        {
            if (Volum <= 50)
            {
                Volum=Volum+5;
                Console.WriteLine($"Volumul boxei {Nume} a crescut la {Volum}");

            }
            else
            {
                Console.WriteLine($"Volumul boxei {Nume} este peste 50% !!!");
            }
            
        }

        public void ScadeVolum()
        {
            if (Volum > 5)
            {
                Volum=Volum-5;
                Console.WriteLine($"Volumul boxei {Nume} a scazut la {Volum}");

            }
            else
            {
                Console.WriteLine($"Volumul boxei {Nume} este sub 5% !!!");
            }
        }

        public void ConecteazaLaCalculator()
        {
            Console.WriteLine($"Boxa {Nume} a fost conectată la calculator.");
        }
    }
}
