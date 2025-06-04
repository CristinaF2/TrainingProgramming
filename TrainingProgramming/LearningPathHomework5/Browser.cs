using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.LearningPathHomework5
{
    public class Browser
    {
        public void FindElement()
        {
            throw new Exception("Eroare: Elementul specificat nu a fost găsit pe pagină");
        }

        public void SendTextToElement()
        {
            try
            {
                FindElement();
            }
            catch (Exception ex)
            {
                BrowserHelper.CaptureScreen();
            }
            finally
            {
                BrowserHelper.PathImage = "C:\\Users\\User\\Desktop\\TrainingProgramming\\LearningPathHomework5\\BrowserHelper.cs";
            }
        }
    }
}