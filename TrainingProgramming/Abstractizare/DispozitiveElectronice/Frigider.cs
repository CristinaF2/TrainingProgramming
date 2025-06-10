using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class Frigider : Dispozitiv
    {
        public Frigider(string nume) : base(nume)
        {
        }

        public override void Porneste()
        {
            if (Pornit)
                Console.WriteLine($"Frigiderul {Nume} este deja pornit.");
            else
            {
                Pornit = true;
                Console.WriteLine($"Frigiderul {Nume} a fost pornit.");
            }
        }

        public override void Opreste()
        {
            {
                if (!Pornit)
                    Console.WriteLine($"Frigiderul {Nume} este deja oprit.");
                else
                {
                    Pornit = false;
                    Console.WriteLine($"Frigiderul {Nume} a fost oprit.");
                }
            }
            
        }
    }
}
