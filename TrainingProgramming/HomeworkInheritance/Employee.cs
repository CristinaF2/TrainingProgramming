namespace TrainingProgramming.HomeworkInheritance
{
    public class Employee : Person
    {
        private string department;
        private decimal salary;
        private int seniority;
        private string manager;


        public Employee(string name, int age, string department, decimal salary, int seniority, string manager)
            : base(name, age)
        {
            this.department = department;
            this.salary = salary;
            this.seniority = seniority;
            this.manager=manager;
        }

        public void SetDepartment(string department)
        {
            this.department = department;
        }
        public string GetDepartment()
        {
            return department;
        }
        public void SetSalary(decimal salary)
        {
            this.salary = salary;
        }
        public decimal GetSalary()
        {
            return salary;
        }

        public void SetSeniority(int seniority)
        {
            this.seniority = seniority;
        }
        public decimal GetSeniority()
        {
            return seniority;
                
        }
        public void SetManager(string manager)
        {
            this.manager = manager;
        }
        public string GetManager()
        {
            return manager;

        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee: {Name}, Department: {department}, Salary: {salary}, Seniority: {seniority}, Manager: {manager}");

        }
    }
    
   
}
