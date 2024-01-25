namespace Lab1
{
    class Relation
    {
        private string RelationType;

        public Relation(string type)
        {
            // Must be "Brother", "Sister", "Mother", or "Father" otherwise Invalid
            if (type == "Brother" | type == "Sister" | type == "Mother" | type == "Father")
            {
                RelationType = type;
            }
            else
            {
                RelationType = "Invalid";
            }
        }

        public void ShowRelationShip(Person person1, Person person2)
        {
            // ShowRelationShip: accepts two Person objects and displays the relationship between them
            Console.WriteLine($"Relationship between {person1.FirstName} and {person2.FirstName} is: {RelationType}hood");
        }
    }
}
