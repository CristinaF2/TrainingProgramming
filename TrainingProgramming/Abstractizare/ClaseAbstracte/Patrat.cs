using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.ClaseAbstracte
{
    public class Patrat : FormeGeometrice
    {
        public int Latura { get; set; }
        public override void CalculArie()
        {
            Console.WriteLine($"Aria patratului este: {Math.Pow(Latura,2)}");
        }
    }
}
