from abc import ABC, abstractmethod


class Animal(ABC):

    # def __init__(self, species):
    #     self.species = species

    # def get_species(self):
    #     return self.species

    @abstractmethod
    def make_sound(self) -> str:
        pass


class Cat(Animal):

    def make_sound(self) -> str:
        return "meow"


class Dog(Animal):

    def make_sound(self) -> str:
        return "woof-woof"


class Chicken(Animal):

    def make_sound(self) -> str:
        return "chick-chick"


def animal_sound(animals: list[Animal]):
    for animal in animals:
        print(animal.make_sound())


animals = [Cat(), Dog(), Chicken()]
animal_sound(animals)
