using System.Security.Cryptography.X509Certificates;

namespace TrainingProgramming
{
    public class Class1
    {
        
        [Test]
        public void Test()
        {
            Console.WriteLine("How many cool numbers do you want: ");
            int count=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i<=10; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

        }

    }
}
