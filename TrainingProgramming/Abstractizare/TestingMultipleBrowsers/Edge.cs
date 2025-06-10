using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.TestingMultipleBrowsers
{
    public class Edge : Browser, INavigabil
    {
        public Edge(string nume) : base(nume)
        {
        }

        public override void Deschide()
        {
            if (Deschis==false)
            {

                Deschis = true;
                Console.WriteLine("Edge a fost deschis.");
            }
            else
            {
                Console.WriteLine("Edge este deschis.");
            }
        }

        public override void Inchide()
        {
            if (Deschis == true)
            {
                Deschis = false;
                Console.WriteLine("Edge a fost închis.");
            }
            else
            {
                Console.WriteLine("Edge este deja închis.");
            }

        }
        public void NavigheazaLa(string url)
        {
            Console.WriteLine($"Edge navighează la adresa {url}.");
        }
    }
}
