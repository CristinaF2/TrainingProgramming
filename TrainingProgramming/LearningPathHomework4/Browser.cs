﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework4
{
    public abstract class Browser
    {
        private int windowWidth;
        public int WindowWidth
        {
            get { return windowWidth; }
            set
            {
                if (value < 1024 || value > 1920)
                {
                    Console.WriteLine("Invalid value. WindowWidth must be between 1024 and 1920.");
                }
                else
                {
                    windowWidth = value;
                }

            }
        }

        public abstract void StartBrowser();
    }
}
