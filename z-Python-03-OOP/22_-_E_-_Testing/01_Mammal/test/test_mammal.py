from project.mammal import Mammal

import unittest


class MammalTests(unittest.TestCase):
	def setUp(self):
		self.values = {
			"name": "Sharo",
			"type": "dog",
			"sound": "wof",
			"kingdom": "animals",
		}
		self.mammal = Mammal(self.values['name'], self.values['type'], self.values['sound'])

	def test_mammal_is_initialized_correctly(self):
		self.assertEqual('Sharo', self.mammal.name)
		self.assertEqual('dog', self.mammal.type)
		self.assertEqual('wof', self.mammal.sound)
		# self.assertEqual('animals', self.mammal.get_kingdom())

	def test_make_sound(self):
		actual = f"{self.values['name']} makes {self.values['sound']}"
		result = self.mammal.make_sound()
		self.assertEqual(actual, result)

	def test_get_kingdom(self):
		actual = self.values['kingdom']
		result = self.mammal.get_kingdom()
		self.assertEqual(actual, result)

	def test_info(self):
		actual = f"{self.values['name']} is of type {self.values['type']}"
		result = self.mammal.info()
		self.assertEqual(actual, result)


if __name__ == "__main__":
	unittest.main()
