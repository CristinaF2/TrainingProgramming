using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework4
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
           
            Firefox firefox = new Firefox();
            Skype skype = new Skype();
           
            firefox.StartBrowser();
            firefox.About();
            firefox.Ping();
            firefox.WindowWidth = 1366;
            Console.WriteLine($"Valoarea setata pentru WindowWidth este: {firefox.WindowWidth}");
            firefox.WindowWidth = 800;


            skype.About();
            skype.Ping();
            
        }
    }
}
