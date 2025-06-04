using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework4
{
    public class Firefox : Browser, IComponent, INetwork
    {
        public override void StartBrowser()
        {
            Console.WriteLine("Firefox browser has started");
        }

        public void About()
        {
            Console.WriteLine("Firefox is a nice browser");
        }

        public void Ping()
        {
            Console.WriteLine("Ping on Firefox");
        }
    }
}
