namespace TrainingProgramming.HomeworkInheritance
{
    
    public class Test
    {
        [Test]
        public void TestMethod()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Employee("Pop Andrei", 22, "Testare", 1200, 5, "Tanase Marian"));
            persons.Add(new Employee("Ionescu Maria", 38, "HR", 1800, 13,"Tanase Marian"));
            persons.Add(new Employee("Carmen Tudose", 27, "HR", 2100, 7, "Tanase Marian"));
            persons.Add(new Employee("Vasile Ion", 45, "Development", 2500, 8, "Pescariu Dana"));
            persons.Add(new Employee("Mircea Rus", 36, "Development", 2300, 2, "Pescariu Dana"));
            persons.Add(new Employee("Paul Maria", 33, "Testare", 3300, 22, "Manole Andreea"));
        
            persons.Add(new Manager("Tanase Marian", 40, 10, 2000));
            persons.Add(new Manager("Manole Andreea", 35, 15, 3000));
            persons.Add(new Manager("Pescariu Dana", 41, 5, 1200));
            persons.Add(new Manager("Florea Cosmin", 49, 3, 2700));

            for (int i = 0; i < persons.Count; i++)
            {
                persons[i].DisplayInfo();
            }

            //da o marire de 200 tuturor angajatilor cau mai mult de 10 ani vechime
            foreach (Person person in persons)
            {
                if (person is Employee employee && employee.GetSeniority() > 10)
                {
                    decimal newSalary = employee.GetSalary() + 200;
                    employee.SetSalary(newSalary);
                }
            }

            //aplica o marire de 10% tuturor angajatilor din departamentul de development
            foreach (Person person in persons)
            {
                if (person is Employee employee && employee.GetDepartment() == "Development")
                {
                    decimal newSalary = (employee.GetSalary() * 10)/100 + employee.GetSalary();
                    employee.SetSalary(newSalary);
                }
            }

            //muta angajatul cu numele Mircea Rus pe departamentul de Testare
            foreach (Person person in persons)
            {
                if (person is Employee employee && employee.Name == "Mircea Rus")
                {
                    employee.SetDepartment("Testare");
                    break;
                }
            }
                      

            //muta toti angajatii de la managerul Tanase Marian la managerul Pescariu Dana
            int noOfEmployees = 0;
            foreach (Person person in persons)
            {
                if (person is Employee employee && employee.GetManager() == "Tanase Marian")
               
                {
                   
                    employee.SetManager("Pescariu Dana");
                    noOfEmployees++;

                }
            }

            //creste nr de angajati ai managerului Pescariu Dana cu ultimii angajati mutati
            foreach (Person person in persons)
            {
                if (person is Manager manager && manager.Name == "Pescariu Dana")
                {
                 
                    manager.SetTeamSize(manager.GetTeamSize()+noOfEmployees);
                    break;
                }
            }

            //scade nr de angajati ai managerului Tanase Marian cu ultimii angajati mutati
            foreach (Person person in persons)
            {
                if (person is Manager manager && manager.Name == "Tanase Marian")
                {

                    manager.SetTeamSize(manager.GetTeamSize()-noOfEmployees);
                    break;
                }
            }

            //bonus 1000 pt toti managerii cu 10 sau mai mult angajati
            foreach (Person person in persons)
            {
                if (person is Manager manager && manager.GetTeamSize() >= 10)
                {
                   manager.SetBonus(manager.GetBonus() + 1000);
                }
            }

            Console.WriteLine();
            //afiseaza angajatii si managerii lor 
            for (int i = 0; i < persons.Count; i++)
            {
                persons[i].DisplayInfo();
            }


        }

    }
}
