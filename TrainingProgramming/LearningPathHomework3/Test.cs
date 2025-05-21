using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework3
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
          
            Firefox firefox = new Firefox();
            firefox.ChangeWindowWidth(1024);
            firefox.About();
            firefox.SetProfile("Profile 1");

            Console.WriteLine();
                        
            Chrome chrome = new Chrome();
            chrome.ChangeWindowWidth("1280px");
            chrome.About();

            Console.WriteLine();
                       
            InternetExplorer ie = new InternetExplorer();
            ie.ChangeWindowWidth(800);
            ie.About();

            Console.WriteLine();
                        
            Edge edge = new Edge();
            edge.version = 12;
            edge.ChangeWindowWidth(1366);
            edge.About();
            edge.NewFeatureFunction();
        }
    }
}
