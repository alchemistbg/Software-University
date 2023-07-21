# import unittest
#
# from person import Person
#
#
# class PersonTests(unittest.TestCase):
# 	def test_person_is_properly_initiated(self):
# 		person = Person("John")
# 		self.assertEquals(person.name, "John")

import unittest

from person import Person


class PersonTests(unittest.TestCase):
	def setUp(self):
		self.person = Person("John", "Doe", 33)

	def tearDown(self):
		self.person = None

	def test_person_is_properly_instantiated(self):
		self.assertEqual(self.person.first_name, "John")
		self.assertEqual(self.person.last_name, "Doe")
		self.assertEqual(self.person.age, 33)

	def test_get_full_name(self):
		full_name = self.person.get_full_name()
		self.assertEqual(full_name, "John Doe")

	def test_get_info(self):
		info = self.person.get_info()
		self.assertEqual(info, "John Doe is 33 years old.")


if __name__ == "main":
	unittest.main()
