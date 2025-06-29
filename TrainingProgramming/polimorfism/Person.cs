﻿namespace TrainingProgramming.polimorfism
{
    public class Person
    {
        private string Nume { get; set; }
        private string Prenume { get; set; }
        private int Varsta { get; set; }

        public Person(string nume, string prenume, int varsta)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Nume: {Nume}, Prenume: {Prenume}, Varsta: {Varsta}");
        }

        public virtual void Mananca()
        {
            Console.WriteLine("Persoana mananca.");
        }


    }
}
