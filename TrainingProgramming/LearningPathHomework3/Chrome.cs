using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework3
{
    public class Chrome : Browser
    {
        

        public void ChangeWindowWidth(string val)
        {
            WindowWidth_string = val;
            Console.WriteLine("Chrome window width set to: " + val);
        }
    }
}
