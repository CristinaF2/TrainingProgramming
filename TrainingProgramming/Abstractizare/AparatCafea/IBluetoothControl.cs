using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.AparatCafea
{
    public interface IBluetoothControl
    {
        public void ConecteazaLaTelefon(string numeDispozitiv);
        public void DeconecteazaDeLaTelefon(string numeDispozitiv);
    }
}
