using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.AparatCafea
{
    public class Expressor : AparatCafea, IAreTimer, IBluetoothControl
    {
        public Expressor(string marca) : base(marca)
        {
        }

        public void ConecteazaLaTelefon(string numeDispozitiv)
        {
            Console.WriteLine($"{Marca}: Contectat la {numeDispozitiv} prin Bluetooth ");
        
        }

        public void DeconecteazaDeLaTelefon(string numeDispozitiv)
        {
            Console.WriteLine($"{Marca}: Deconectat de la Bluetooth");
        }

        public override void FaCafea(string tip)
        {
            Console.WriteLine($"{Marca}: Prepar cafea de tip {tip} din boabe");  
        }

        public override void Opreste()
        {
            Console.WriteLine($"{Marca}: Expresor oprit");   
        }

        public override void Porneste()
        {
            Console.WriteLine($"{Marca}: Expresor pornit");    
        }

        public void SeteazaTimer(int minute)
        {
            Console.WriteLine($"{Marca}: Timer setat pentru {minute} minute ");      
        }

    }
}
