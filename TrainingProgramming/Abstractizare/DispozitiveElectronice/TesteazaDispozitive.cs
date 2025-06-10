using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.DispozitiveElectronice
{
    public class TesteazaDispozitive
    {
        [Test]
        public void TestMethod()
        {
            
            Calculator calculator = new Calculator("Lenovo",22);
            Televizor televizor = new Televizor("Sony");
            // Pornim si oprim dispozitivele
            calculator.Porneste();
            calculator.Porneste();
            calculator.Opreste();
            calculator.Opreste();

            Console.WriteLine();

            televizor.Opreste();
            televizor.Porneste();
            televizor.Opreste();

            
            List<Dispozitiv> dispozitive = new List<Dispozitiv>
            {
               new Televizor("Samsung"),
               new Calculator("Dell",55),
               new Televizor("Sony"),
               new Televizor("Albatros"),
          
            };          
            Console.WriteLine("---");

            foreach (var dispozitiv in dispozitive)
            {
                dispozitiv.Porneste();
            }

            Console.WriteLine("---");

            foreach (var dispozitiv in dispozitive)
            {
                dispozitiv.Opreste();
            }

            Console.WriteLine("---");


            Router router = new Router("Asus");
            router.ConecteazaLaInternet();
            router.Porneste();
            router.ConecteazaLaInternet();
            router.Opreste();

            Console.WriteLine("---");

            Boxa boxa = new Boxa("JBL", 51);
            boxa.Porneste();
            boxa.CresteVolum();
            boxa.ScadeVolum();

            Boxa boxa2 = new Boxa("Sony", 4);
            boxa2.Porneste();
            boxa2.ScadeVolum();
            boxa2.CresteVolum();
            boxa2.ConecteazaLaCalculator();




        }
    }
}
