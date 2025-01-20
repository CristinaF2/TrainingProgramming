using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Sesiune1
{
    public class Cursant
    {
        string numeCursant;
        string prenume;
        int varsta;
        int cpn;
        bool isActive;
        char gen;
        float nota;
        double inaltime;

        [Test]
        public void MetodaTest()
        {

            numeCursant="Filipan";
            prenume="Cristina";
            varsta=34;
            //cpn=2900427245145;
            var cpn = 2900427245145;

            isActive= true;
            gen='F';
            nota=5.69f;
            inaltime=1.75d;

            Console.WriteLine("Numele si prenumele cursantului este: "+numeCursant+" "+prenume);
            Console.WriteLine("Prenumele cursantului este: "+prenume);
            Console.WriteLine("Varsta cursantului este: "+varsta);

        }

    }
}
