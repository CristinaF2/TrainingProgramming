using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.AparatCafea
{
    public abstract class AparatCafea
    {
        public string Marca { get; set; }

        public  AparatCafea(string marca)
        {
            Marca = marca;
        }

        public abstract void Porneste();
        public abstract void Opreste();
        public abstract void FaCafea(string tip);
        public void Curata()
        {
            Console.WriteLine($"Aparatul de cafea {Marca} a fost curatat.");
        }
    }
}
