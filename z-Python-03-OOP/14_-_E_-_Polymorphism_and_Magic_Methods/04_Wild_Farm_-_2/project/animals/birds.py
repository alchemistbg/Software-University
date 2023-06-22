from .animal import Bird
from project.food import Meat


class Owl(Bird):
	_FOOD_PREFERENCES = (Meat,)
	_WEIGHT_GAIN = 0.25

	def make_sound(self):
		return "Hoot Hoot"


class Hen(Bird):
	_FOOD_PREFERENCES = None
	_WEIGHT_GAIN = 0.35

	def make_sound(self):
		return "Cluck"
