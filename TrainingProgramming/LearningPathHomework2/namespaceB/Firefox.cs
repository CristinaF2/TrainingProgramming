using Newtonsoft.Json.Linq;
using System;

namespace TrainingProgramming.LearningPathHomework2.namespaceB
{
    public class Firefox
    {
        private int WindowWidth_int;
        private string WindowWidth_string;
        private double WindowWidth_double;

        //In Main method: for Firefox object set value 1920 to all 3 defined variables(in Firefox class).
        // Convert int to string, string to double, and double to int and display in console the values.

        public Firefox(int a, string b, double c) 
        { 
            WindowWidth_int = a;
            WindowWidth_string = b;
            WindowWidth_double = c;
        }

        public string ConvertIntToString()
        {
            string value1 = WindowWidth_double.ToString();
            return value1;
        }

        public double ConvertStringToDouble()
        {
            double value2= Convert.ToDouble(WindowWidth_string);
            return value2;
        }


        public int ConvertDoubleToInt()
        {
            int value3 = Convert.ToInt32(WindowWidth_double);
            return value3;
        }

        public void DisplayValues(string a, double b, int c)
        {

            Console.WriteLine($"The first value is {a}");
            Console.WriteLine($"The second value is {b}");
            Console.WriteLine($"The third value is {c}");
        }


    }
}
