using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.TestingMultipleBrowsers
{
    public  class Chrome : Browser, IAutentificabil, IDebugabble, INavigabil
    {
        public Chrome(string nume) : base(nume)
        {
        }
        public  void NavigheazaLa(string url)
        {
            Console.WriteLine($"Navighez la adresa: {url} folosind Chrome.");
        }
               

        public void AfiseazaLoguri()
        {
            Console.WriteLine("Chrome: Afișare loguri de debug.");
        }


        public override void Deschide()
        {
            if (Deschis==false)
            {

                Deschis = true;
                Console.WriteLine("Chrome a fost deschis.");
            }
            else
            {
                Console.WriteLine("Chrome este deschis.");
            }
        }

        public override void Inchide()
        {
            if (Deschis == true)
            {
                Deschis = false;
                Console.WriteLine("Chrome a fost închis.");
            }
            else
            {
                Console.WriteLine("Chrome este deja închis.");
            }

        }

        public void Login(string user, string parola)
        {
            Console.WriteLine($"Chrome: Autentificare cu userul: {user}.");
        }
    }
    

    
}
