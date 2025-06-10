using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.Abstractizare.TestingMultipleBrowsers
{
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            Chrome chrome = new Chrome("Chrome");
            Firefox firefox = new Firefox("Firefox");
            Edge edge = new Edge("Edge");


            chrome.Deschide();
            chrome.NavigheazaLa("https://google.com");
            chrome.Login("user1", "123");
            chrome.AfiseazaLoguri();
            chrome.Inchide();

            Console.WriteLine("----");

            firefox.Deschide();
            firefox.NavigheazaLa("https://google.com");
            firefox.Login("user1", "123");
            firefox.Inchide();

            Console.WriteLine("----");


            edge.Deschide();
            edge.NavigheazaLa("https://google.com");
            edge.Inchide();





        }
    }
}
