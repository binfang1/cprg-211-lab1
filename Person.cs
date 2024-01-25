namespace Lab1
{
    class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColour;
        private int age;
        private bool isWorking;

        public string FirstName { get => firstName; set => firstName = value; }
        public string FavoriteColour { get => favoriteColour; set => favoriteColour = value; }
        public int Age { get => age; set => age = value; }

        public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColour = favoriteColour;
            this.age = age;
            this.isWorking = isWorking;
        }

        public void DisplayPersonInfo()
        {
            // Displays the instances' personal info
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}");
        }

        public void DisplayPersonInfo(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
        {
            // DisplayPersonInfo: accepts the six person attributes and displays (Name= firstName + lastName) personId: Name’s favorite color is favoriteColour 
            Console.WriteLine($"{personId}: {firstName} {lastName}'s favorite color is {favoriteColour}");
        }

        public void ChangeFavoriteColour()
        {
            // ChangeFavoriteColour: changes the person’s favorite colour to white
            favoriteColour = "White";
        }

        public int GetAgeInTenYears()
        {
            // GetAgeInTenYears: get the person’s age after 10 years
            return age + 10;
        }

        public override string ToString()
        {
            // ToString method: displays all Person Object information as a list
            return $"PersonId: {personId}\nFirstName: {firstName}\nLastName: {lastName}\nFavoriteColour: {favoriteColour}\nAge: {age}\nIsWorking: {isWorking}";
        }
    }
}
