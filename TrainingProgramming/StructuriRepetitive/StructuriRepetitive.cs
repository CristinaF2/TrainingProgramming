using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.StructuriRepetitive
{
    public class StructuriRepetitive
    {

        [Test]
        public void Test()
        {
            /*
            for (int i = 1; i<=7; i++)
            {
                Console.WriteLine(i);
            }
            */
            /*
            int i = 1;
            for (; i<=8; i++)
            {
                Console.WriteLine(i);
            }
            
            int i = 1;
            for (; i<=7;)
            {
                Console.WriteLine(i);
                i++;
            }
            

            string[] numeColegi = new string[3];
            numeColegi[0] = "Ioana";
            numeColegi[1] = "Vasile";
            numeColegi[2] = "Miruna";
            
            for (int i = 0; i < numeColegi.Length; i++)
            {
                Console.WriteLine(numeColegi[i]);
            }

            List<string> numeColegi2 = new List<string>
            {
                "A","B","C"
            };

            foreach(string numeColeg in numeColegi2)
            {
                Console.WriteLine(numeColeg);
            }
            

            for (int i=0; i <=10; i++)
            {
                if (i==4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            */
            // Declarăm un array de string-uri
            string[] pisici = { "Cica", "Tomi", "Teddy", "Lucy", "Vulpita", "Louie", "Piti", "Norocel", "Fetita" };

            Console.WriteLine("Pisicile mele se numesc:");

            // Iterăm prin array folosind foreach
            foreach (string pisica in pisici)
            {
                Console.WriteLine(pisica);
            }
        }
    }
}
