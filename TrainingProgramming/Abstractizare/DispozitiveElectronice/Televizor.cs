using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class Televizor : Dispozitiv
    {
        public Televizor(string nume) : base(nume)
        {
        }

        public override void Porneste()
        {
            if (Pornit)
            {
                Console.WriteLine($"Televizorul {Nume} a fost deja pornit");

            }
            else
            {
                Pornit = true;
                Console.WriteLine($"Televizorul {Nume} a fost pornit acum");
                
            }
        }
        public override void Opreste()
        {
            if (Pornit==false)
            {
                Console.WriteLine($"Televizorul {Nume} este deja oprit");
                return;
            }
            else
            {
                Pornit = false;
                Console.WriteLine($"Televizorul {Nume} a fost oprit acum");
            }
           
        }
    }
    
}
