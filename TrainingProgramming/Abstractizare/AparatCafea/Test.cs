using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.AparatCafea
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            AparatPeCapsule aparatPeCapsule = new AparatPeCapsule("Nespresso");
            Expressor expressor = new Expressor("Philips");

            aparatPeCapsule.Porneste();
            aparatPeCapsule.FaCafea("Latte machiato");
            aparatPeCapsule.Opreste();
            aparatPeCapsule.Curata();

            Console.WriteLine("---");

            expressor.Porneste();
            expressor.ConecteazaLaTelefon("Samsung");
            expressor.SeteazaTimer(5);
            expressor.FaCafea("Espresso");
            expressor.DeconecteazaDeLaTelefon("Samsung");
            expressor.Opreste();
            expressor.Curata();
            

        }
    }
}
