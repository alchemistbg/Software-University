class Person:

    def __init__(self, name, age):
        self.__name = name
        self.__age = age

    @property
    def name(self):
        return self.__name

    @name.setter
    def name(self, new_name):
        self.__name = new_name

    @property
    def age(self):
        return self.__age

    @age.setter
    def age(self, new_age):
        self.__name = new_age


# The following lines test properties
person = Person("George", 32)
print(person.name)
print(person.age)
person.name = 'Gancho'
print(person.name)
person.age = 33
print(person.age)
