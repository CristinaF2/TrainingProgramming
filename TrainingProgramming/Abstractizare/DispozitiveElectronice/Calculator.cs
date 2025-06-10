using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class Calculator : Dispozitiv, IAreVolum
    {
        public int Volum { get; set; } // Default volume level
        public Calculator(string nume, int volum) : base(nume)
        {
            Volum=volum;
        }

        public override void Porneste()
        {
            if (Pornit)
            {
                Console.WriteLine($"Calculatorul {Nume} a fost deja pornit");

            }
            else
            {
                Pornit = true;
                Console.WriteLine($"Calculatorul {Nume} a fost pornit acum");

            }
        }
        public override void Opreste()
        {
            if (Pornit==false)
            {
                Console.WriteLine($"Calculatorul {Nume} este deja oprit");
                return;
            }
            else
            {
                Pornit = false;
                Console.WriteLine($"Calulatorul {Nume} a fost oprit acum");
            }
        }

        public void CresteVolum()
        {
            if (Volum <= 50)
            {
                Volum=Volum+5;
                Console.WriteLine($"Volumul calculatorului {Nume} a crescut la {Volum}");

            }
            else
            {
                Console.WriteLine($"Volumul calculatorului {Nume} este peste 50% !!!");
            }

        }

        public void ScadeVolum()
        {
            if (Volum > 5)
            {
                Volum=Volum-5;
                Console.WriteLine($"Volumul calculatorului {Nume} a scazut la {Volum}");

            }
            else
            {
                Console.WriteLine($"Volumul calculatorului {Nume} este sub 5% !!!");
            }
        }

    }

}
