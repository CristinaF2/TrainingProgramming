namespace TrainingProgramming.Abstractizare
{
    public class OOPTest
    {

        [Test]
        public void TestMethod()
        {
            Employee employee1 = new Employee("Cristina", "Filipan", 35, "Testare", 1200);
            employee1.GoToWork();
            employee1.TakeABreak();

            EmployeeStudent employeeStudent1 = new EmployeeStudent("Ioana", "Pop", 25, "Testare", 1200, "UPT", "Informatica");
            employeeStudent1.GoToWork();
            employeeStudent1.TakeABreak();
            employeeStudent1.Study();
        }
    }
}
