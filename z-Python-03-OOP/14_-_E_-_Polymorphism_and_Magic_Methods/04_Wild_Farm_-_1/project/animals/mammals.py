from .animal import Mammal
from project.food import Food


class Mouse(Mammal):

	def make_sound(self):
		return "Squeak"

	def feed(self, food):
		food_type = food.__class__.__name__
		animal_type = self.__class__.__name__
		if food_type not in ['Vegetable', 'Fruit']:
			return f"{animal_type} does not eat {food_type}!"
		self.food_eaten += food.quantity
		self.weight += 0.1 * food.quantity


class Dog(Mammal):

	def make_sound(self):
		return "Woof!"

	def feed(self, food):
		food_type = food.__class__.__name__
		animal_type = self.__class__.__name__
		if food_type != 'Meat':
			return f"{animal_type} does not eat {food_type}!"
		self.food_eaten += food.quantity
		self.weight += 0.4 * food.quantity


class Cat(Mammal):

	def make_sound(self):
		return "Meow"

	def feed(self, food):
		food_type = food.__class__.__name__
		animal_type = self.__class__.__name__
		if food_type not in ['Vegetable', 'Meat']:
			return f"{animal_type} does not eat {food_type}!"
		self.food_eaten += food.quantity
		self.weight += 0.3 * food.quantity


class Tiger(Mammal):

	def make_sound(self):
		return "ROAR!!!"

	def feed(self, food: 'Food'):
		food_type = food.__class__.__name__
		animal_type = self.__class__.__name__
		if food_type != 'Meat':
			return f"{animal_type} does not eat {food_type}!"
		self.food_eaten += food.quantity
		self.weight += 1.0 * food.quantity
