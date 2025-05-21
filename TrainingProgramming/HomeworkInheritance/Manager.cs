using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProgramming.HomeworkInheritance
{
    public class Manager : Person
    {

        private int teamSize;
        private decimal bonus;

        public Manager(string name, int age, int teamSize, decimal bonus) : base(name, age)
        {
            this.teamSize=teamSize;
            this.bonus=bonus;
        }

        public void SetTeamSize(int size)
        {
            this.teamSize = size;
            
        }
        public int GetTeamSize()
        {
            return teamSize;

        }


        public void SetBonus(decimal amount)
        {
            this.bonus = amount;

        }
        public decimal GetBonus()
        {
            return bonus;

        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, Leads a team of {teamSize} people, Bonus: {bonus}");
            
        }

        
    }
  
}
