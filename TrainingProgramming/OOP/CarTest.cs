namespace TrainingProgramming.OOP
{
    public class CarTest
    {
        [Test]
        public void TestMethod()
        {
            var car1=new Car("Diesel","red",3 , 1.3);
            car1.DisplayeData();

            Console.WriteLine();

            Car car2 = new Car("Gasoline", "blue", 4, 2.3);
            car2.DisplayeData();

            Console.WriteLine();

            Car car3=new Car("Gasoline", "blue", 4, 2.3, "automata");
            car3.DisplayeData();

           


        }
    }
}
