using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.AparatCafea
{
    public class AparatPeCapsule : AparatCafea
    {
        public AparatPeCapsule(string marca) : base(marca)
        {
        }

        public override void FaCafea(string tip)
        {
            Console.WriteLine($"{Marca}: Prepar cafea de tip {tip} din capsula");
        }

        public override void Opreste()
        {
            Console.WriteLine($"{Marca}: Aparat pe capsule oprit");
        }

        public override void Porneste()
        {
            Console.WriteLine($"{Marca}: Aparat pe capsule pornit");
        }
    }
}
