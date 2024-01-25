namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates all people
            Person ian = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person gina = new Person(2, "Gina", "James", "Green", 18, false);
            Person mike = new Person(3, "Mike", "Briscoe", "Blue", 45, true);
            Person mary = new Person(4, "Mary", "Beals", "Yellow", 28, true);

            gina.DisplayPersonInfo();
            Console.WriteLine(mike.ToString());
            ian.ChangeFavoriteColour();
            ian.DisplayPersonInfo();
            Console.WriteLine($"Mary Beals's Age in 10 years is: {mary.GetAgeInTenYears()}");

            // Creates relations
            Relation sis = new Relation("Sister");
            Relation bro = new Relation("Brother");

            sis.ShowRelationShip(gina, mary);
            bro.ShowRelationShip(ian, mike);

            List<Person> personList = new List<Person> { ian, gina, mike, mary };

            Console.WriteLine($"Average age is: {AverageAge(personList)}");
            Console.WriteLine($"The youngest person is: {Youngest(personList).FirstName}");
            Console.WriteLine($"The oldest person is: {Oldest(personList).FirstName}");

            // Prints each person that starts with M
            foreach (Person person in StartsWithM(personList))
            {
                Console.WriteLine(person.ToString());
            }

            // Prints each person that likes blue
            foreach (Person person in LikesBlue(personList))
            {
                Console.WriteLine(person.ToString());
            }
        }

        private static float AverageAge(List<Person> list)
        {
            int sum = 0;
            foreach (Person person in list)
            {
                sum += person.Age;
            }
            return (float)sum / list.Count;
        }

        private static Person Youngest(List<Person> list)
        {
            Person youngest = list[0];
            foreach (Person person in list)
            {
                if (person.Age < youngest.Age)
                {
                    youngest = person;
                }
            }
            return youngest;
        }

        private static Person Oldest(List<Person> list)
        {
            Person oldest = list[0];
            foreach (Person person in list)
            {
                if (person.Age > oldest.Age)
                {
                    oldest = person;
                }
            }
            return oldest;
        }

        private static List<Person> StartsWithM(List<Person> list)
        {
            List<Person> startsWithM = new List<Person>();
            foreach (Person person in list)
            {
                if (person.FirstName.StartsWith("M"))
                {
                    startsWithM.Add(person);
                }
            }
            return startsWithM;
        }

        private static List<Person> LikesBlue(List<Person> list)
        {
            List<Person> likesBlue = new List<Person>();
            foreach (Person person in list)
            {
                if (person.FavoriteColour == "Blue")
                {
                    likesBlue.Add(person);
                }
            }
            return likesBlue;
        }
    }
}



