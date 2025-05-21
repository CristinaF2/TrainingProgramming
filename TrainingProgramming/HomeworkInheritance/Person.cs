namespace TrainingProgramming.HomeworkInheritance
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //metodele abstracte trebuie implementate in clasele derivate fiindca nu au body
        //metodele virtuale pot fi suprascrise in clasele derivate dar nu TREBUIE fiindca au body
        public abstract void DisplayInfo();
    }
}
