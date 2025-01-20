

namespace TrainingProgramming.StructuriAlternative
{
    public class Exercise
    {
        [Test]
        public void TestMethod()
        {
            //VerificareNumar(5, 12);
            //VerificareNumar(21, 3);
            CompareDigits(5);
            VerificareMasina("Cristina");

        }

        public void VerificareNumar(int x, int y)
        {
            if (x<y)
            {
                Console.WriteLine($"Numarul {x} este mai mic decat numarul {y}");
            }
            else
            {
                Console.WriteLine($"Numarul {x} este mai mare decat numarul {y}");
            }

        }

        public void CompareDigits(int x)
        {
            if (x<5)
            {
                Console.WriteLine($"Numaru {x} este mai mic decat 5");
            }
            else if (x>5)
            {
                Console.WriteLine($"Numaru {x} este mai mare decat 5");
            }
            else 
            {
                Console.WriteLine($"Numaru {x} este egal cu 5");
            }

        }

        public void VerificareMasina(string masina)
        {
            switch (masina)
            {
                case "Mercedes":
                    Console.WriteLine("Este disponibil Mercedes");
                    break;
                case "Opel":
                    Console.WriteLine("Este disponibil Opel");
                    break;
                case "BMW":
                    Console.WriteLine("Este disponibil BMW");
                    break;
                default:
                    Console.WriteLine("Marca nu este disponibila");
                    break;

            }

        }

    }
}
