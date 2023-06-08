using System;
using System.Collections.Generic;

namespace Lab_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.GetPerson(1, "Ian", "Brooks", "Red", 30, true);

            Person person2 = new Person();
            person2.GetPerson(2, "Gina", "James", "Green", 18, false);

            Person person3 = new Person();
            person3.GetPerson(3, "Mike", "Briscoe", "Blue", 45, true);

            Person person4 = new Person();
            person4.GetPerson(4, "Mary", "Beals", "Yellow", 28, true);

            List<Person> listObjects = new List<Person> 
            {
                person1, person2, person3, person4,
            };


            double sumAge = 0;
            List<Person> peopleWithM = new List<Person>();
            Person youngestPerson = null;
            Person oldestPerson = null;

            foreach (Person person in listObjects)
            {
                sumAge += person.Age;

                if (youngestPerson == null || person.Age < youngestPerson.Age)
                {
                    youngestPerson = person;
                }

                if (oldestPerson == null || person.Age > oldestPerson.Age)
                {
                    oldestPerson = person;
                }

                if (person.FirstName.StartsWith("M"))
                {
                    peopleWithM.Add(person);
                }
            }

            Relation relation1 = new Relation
            {
                RelationshipType = "Sister"
            };

            Relation relation2 = new Relation
            {
                RelationshipType = "Brother"
            };

            Console.WriteLine($"2: {person2.DisplayPersonInfo(favoriteColour: person2.FavoriteColour)}");

            Console.WriteLine($"{person3}");
            Console.WriteLine("");

            Console.WriteLine($"1: {person1.DisplayPersonInfo(favoriteColour: person1.ChangeFavoriteColor())}");
            Console.WriteLine($"{person4.GetAgeInTenYears()}");
            Console.WriteLine($"{relation1.ShowRelationShip(person2, person4)}");
            Console.WriteLine($"{relation2.ShowRelationShip(person1, person3)}");
            Console.WriteLine($"Average age is: {sumAge / listObjects.Count}");
            Console.WriteLine($"The youngest person is: {youngestPerson.FirstName}");
            Console.WriteLine($"The oldest person is: {oldestPerson.FirstName}");
            Console.WriteLine("");

            foreach (Person person in peopleWithM)
            {
                Console.WriteLine(person.ToString());
            }

            //List<Person> personLikesBlue = new List<Person>();

            //foreach (Person person in listObjects)
            //{
            //    if (person.FavoriteColour.Equals("Blue"))
            //    {
            //        personLikesBlue.Add(person);
            //        string person_info = person.ToString();
            //        Console.WriteLine(person_info);
            //    }
            //}
        }
    }
}
