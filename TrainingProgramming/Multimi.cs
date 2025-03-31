namespace TrainingProgramming
{
    public class Multimi
    {
        [Test]
        public void Test1()
        {
            Dictionary<string, string> obiecte = new Dictionary<string, string>
            {
                {"object", "laptop" },
                {"fruit", "mar" },
                {"animal", "cat" }
            };

            foreach (var item in obiecte)
            {
                Console.WriteLine($"The key is: {item.Key} ");
                Console.WriteLine($"The value is: {item.Value} ");
                Console.WriteLine();
            }

            Dictionary<string,List<string>> classifications = new Dictionary<string,List<string>>();
            List<string> citiesOfRomania = new List<string>() { "Bucharest", "Cluj-Napoca", "Timisoara" };
            List<string> citiesOfFrance = new List<string>() { "Paris", "Lyon", "Marseille" };
            List<string> citiesOfGermany = new List<string>() { "Berlin", "Munich", "Hamburg" };

            classifications.Add("Romania", citiesOfRomania);
            classifications["Romania"]=citiesOfRomania;
            classifications["France"]=citiesOfFrance;
            classifications["Germany"]=citiesOfGermany;

            foreach (var classification in classifications)
            {
                foreach (var city in classification.Value)
                {
                    Console.WriteLine($"The country is: {classification.Key}");
                    Console.WriteLine($"The city of the country is: {city}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine("Second variant: ");
            foreach (var key in classifications.Keys)
            {
               
                    Console.WriteLine($"The country is: {key}");
                    Console.WriteLine($"The cities are: "+string.Join(", ", classifications[key]));
                    Console.WriteLine();
                
            }


        }
    }
}
