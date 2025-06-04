using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework4
{
    internal class Skype : IComponent, INetwork
    {
        public void About()
        {
            Console.WriteLine("Skype is a communication platform");
        }
        public void Ping()
        {
            Console.WriteLine("Ping on Skype");
        }
    }

}
