class Person:
    def __init__(self, person_id, first_name, last_name, favorite_color, age, is_working):
        self.person_id = person_id
        self.first_name = first_name
        self.last_name = last_name
        self.favorite_color = favorite_color
        self.age = age
        self.is_working = is_working

    def display_person_info(self, favorite_color):
        name = self.first_name + " " + self.last_name
        return f"{name}'s favorite color is {favorite_color}"

    def change_favorite_color(self):
        self.favorite_color = "White"
        return self.favorite_color

    def get_age_in_ten_years(self):
        return self.age + 10

    def to_string(self):
        return (
            f"PersonId: {self.person_id}\n"
            f"FirstName: {self.first_name}\n"
            f"LastName: {self.last_name}\n"
            f"FavoriteColour: {self.favorite_color}\n"
            f"Age: {self.age}\n"
            f"IsWorking: {self.is_working}"
        )


class Relation:
    def __init__(self, relationship_type):
        self.relationship_type = relationship_type

    def show_relationship(self):
        relationship = self.relationship_type
        return relationship


class Main:
    person1 = Person(1, "Ian", "Brooks", "Red", 30, True)
    person2 = Person(2, "Gina", "James", "Green", 18, False)
    person3 = Person(3, "Mike", "Briscoe", "Blue", 45, True)
    person4 = Person(4, "Mary", "Beals", "Yellow", 28, True)
    people = [person1, person2, person3, person4]

    relation1 = Relation("Sister")
    relation2 = Relation("Brother")

    sum_age = (person1.age + person2.age + person3.age + person4.age) / len(people)

    min_age = float(100)
    max_age = float(0)
    min_person = None
    max_person = None

    for person in people:
        if person.age < min_age:
            min_age = person.age
            min_person = person

        if person.age > max_age:
            max_age = person.age
            max_person = person

    print(f"2: {person2.display_person_info(person2.favorite_color)}\n"
          f"{person3.to_string()}\n"
          )

    print(f"1: {person1.display_person_info(person1.change_favorite_color())}\n"
          f"{person4.first_name} {person4.last_name}'s Age in 10 years is {person4.get_age_in_ten_years()}\n"
          f"Relationship between {person2.first_name} and {person4.first_name} "
          f"is: {relation1.show_relationship()}hood\n"
          f"Relationship between {person1.first_name} and {person3.first_name} "
          f"is: {relation2.show_relationship()}hood\n"
          f"Average age is {sum_age}\n"
          f"The youngest person is {min_person.first_name}\n"
          f"The oldest person is {max_person.first_name}")

    for person in people:
        if person.first_name.startswith("M"):
            person_info = person.to_string()
            print(f"\n{person_info}")

    blue_lovers = []
    for person in people:
        if person.favorite_color == "Blue":
            blue_lovers.append(person)
            person_info = person.to_string()
            print(f"\n{person_info}")


main_program = Main()
