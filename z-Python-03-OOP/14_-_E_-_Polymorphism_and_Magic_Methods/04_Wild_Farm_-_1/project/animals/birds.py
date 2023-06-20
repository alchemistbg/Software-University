from .animal import Bird


class Owl(Bird):

	def make_sound(self):
		return "Hoot Hoot"

	def feed(self, food):
		food_type = food.__class__.__name__
		animal_type = self.__class__.__name__
		if food_type != 'Meat':
			return f"{animal_type} does not eat {food_type}!"
		self.food_eaten += food.quantity
		self.weight += 0.25 * food.quantity


class Hen(Bird):

	def make_sound(self):
		return "Cluck"

	def feed(self, food):
		self.food_eaten += food.quantity
		self.weight += 0.35 * food.quantity
