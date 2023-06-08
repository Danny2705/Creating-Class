using System;

namespace Lab_Class
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FavoriteColour { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }

        public void GetPerson(int personId, string firstName, string lastName,
            string favoriteColour, int age, bool isWorking)
        {
            PersonId = personId;  
            FirstName = firstName;
            LastName = lastName;
            FavoriteColour = favoriteColour;
            Age = age;
            IsWorking = isWorking;  
        }

        public string DisplayPersonInfo(string favoriteColour)
        {
            string name = FirstName + " " + LastName;
            return $"{name}'s favorite color is {favoriteColour}";
        }

        public string ChangeFavoriteColor()
        {
            return FavoriteColour = "White";
        }

        public string GetAgeInTenYears()
        {
            string name = FirstName + " " + LastName;
            return $"{name}'s Age in 10 years is: {this.Age + 10}";
        }

        public override string ToString()
        {
            return $"PersonId: {PersonId}\nFirstName: {FirstName}\n" +
                $"LastName: {LastName}\nFavoriteColors: {FavoriteColour}\n" +
                $"Age: {Age}\nIsWorking: {IsWorking}";
        }
    }
}

