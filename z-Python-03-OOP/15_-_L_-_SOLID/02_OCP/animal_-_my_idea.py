from abc import ABC, abstractmethod


class Animal(ABC):

    @property
    @abstractmethod
    def _SOUND(self):
        pass

    def make_sound(self) -> str:
        return self._SOUND


class Cat(Animal):
    _SOUND = "meow"


class Dog(Animal):
    _SOUND = "woof-woof"


class Chicken(Animal):
    _SOUND = "chick-chick"


def animal_sound(animals: list[Animal]):
    for animal in animals:
        print(animal.make_sound())


animals = [Cat(), Dog(), Chicken()]
animal_sound(animals)

## добавете ново животно и рефакторирайте кода да работи без да се налага да се правят промени по него
## при добавяне на нови животни
# animals = [Animal('cat'), Animal('dog'), Animal('chicken')]
