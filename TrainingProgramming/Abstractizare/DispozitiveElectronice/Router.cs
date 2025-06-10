using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class Router : Dispozitiv, IConectabilLaInternet
    {
        public Router(string nume) : base(nume)
        {
        }

        public override void Porneste()
        {
            if (Pornit)
                Console.WriteLine($"Routerul {Nume} este deja pornit.");
            else
            {
                Pornit = true;
                Console.WriteLine($"Routerul {Nume} a fost pornit.");
            }
        }

        public override void Opreste()
        {
            if (!Pornit)
                Console.WriteLine($"Routerul {Nume} este deja oprit.");
            else
            {
                Pornit = false;
                Console.WriteLine($"Routerul {Nume} a fost oprit.");
            }
        }

        public void ConecteazaLaInternet()
        {
            if (Pornit)
                Console.WriteLine($"Routerul {Nume} s-a conectat la internet.");
            else
                Console.WriteLine($"Routerul {Nume} nu este pornit. Nu se poate conecta la internet.");
        }
    }
}
