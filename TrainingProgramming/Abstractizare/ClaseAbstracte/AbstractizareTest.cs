namespace TrainingProgramming.Abstractizare.ClaseAbstracte
{
    public class AbstractizareTest
    {
        [Test]
        public void TestMethod()
        {
            Cerc cerc= new Cerc { Raza = 5, Culoare = "Albastru" };

            /*Cerc cerc1 = new Cerc();
            cerc1.Raza=5;
            cerc1.Culoare = "Albastru";
            */

            cerc.CalculArie();
            cerc.Deseneaza();

            Patrat patrat=new Patrat { Latura = 4, Culoare = "Rosu" };
            patrat.CalculArie();
            patrat.Deseneaza();



        }
    }
}
