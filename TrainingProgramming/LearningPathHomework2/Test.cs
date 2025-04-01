using TrainingProgramming.LearningPathHomework2.namespaceB;
using TrainingProgramming.LearningPathHomework2.namespaceC;
using TrainingProgramming.LearningPathHomework2.namespaceD;
using Browser = TrainingProgramming.LearningPathHomework2.namespaceA.Browser;
namespace TrainingProgramming.LearningPathHomework2
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            Browser browser = new Browser();
            Firefox firefox = new Firefox(1920,"1920",1920);

            string value1 = firefox.ConvertIntToString();
            double value2 = firefox.ConvertStringToDouble();
            int value3 = firefox.ConvertDoubleToInt();

            firefox.DisplayValues(value1, value2, value3);
            Console.WriteLine();

            Chrome chrome=new Chrome();
            chrome.SetWindowWidthInt(2025);
            chrome.CheckWindowWidthInt();
            Console.WriteLine();


            InternetExplorer internetExplorer = new InternetExplorer();
            internetExplorer.SetWindowWidthInt(1920);
            internetExplorer.CheckWindowWidthInt();


        }
    }
}
