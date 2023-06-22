from .animal import Mammal
from project.food import Vegetable, Fruit, Meat, Seed


class Mouse(Mammal):
	_FOOD_PREFERENCES = (Vegetable, Fruit)
	_WEIGHT_GAIN = 0.1

	def make_sound(self):
		return "Squeak"


class Dog(Mammal):
	_FOOD_PREFERENCES = (Meat, )
	_WEIGHT_GAIN = 0.4

	def make_sound(self):
		return "Woof!"


class Cat(Mammal):
	_FOOD_PREFERENCES = (Vegetable, Meat)
	_WEIGHT_GAIN = 0.3

	def make_sound(self):
		return "Meow"


class Tiger(Mammal):
	_FOOD_PREFERENCES = (Meat, )
	_WEIGHT_GAIN = 1.0

	def make_sound(self):
		return "ROAR!!!"
