using System;

namespace Lab_Class
{
    public class Relation
    {
        public string RelationshipType{ get; set; }

        public string ShowRelationShip(Person person1, Person person2)
        {
            return $"Relationship between {person1.FirstName} " +
                $"and {person2.FirstName} is {RelationshipType}hood";
        }
    }
}
