using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.TestingMultipleBrowsers
{
    public class Firefox : Browser, INavigabil, IAutentificabil
    {
        public Firefox(string nume) : base(nume)
        {
        }

        public override void Deschide()
        {
            if(Deschis==false){

                Deschis = true;
                Console.WriteLine("Firefox a fost deschis.");
            }else
            {
                Console.WriteLine("Firefox este deschis.");
            }
        }

        public override void Inchide()
        {
            if (Deschis == true)
            {
                Deschis = false;
                Console.WriteLine("Firefox a fost închis.");
            }
            else
            {
                Console.WriteLine("Firefox este deja închis.");
            }
          
        }
        public void NavigheazaLa(string url)
        {
            Console.WriteLine($"Firefox navighează la adresa: {url}.");
        }

        public void Login(string user, string parola)
        {
            Console.WriteLine($"Firefox: Autentificare cu userul: {user}.");
        }
    }

}
