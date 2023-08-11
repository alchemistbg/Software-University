from unittest import TestCase, main

from project.toy_store import ToyStore


class ToyStoreTests(TestCase):

	def setUp(self):
		self.store = ToyStore()

	def test_if_store_initialized_correctly(self):
		self.assertEqual(["A", "B", "C", "D", "E", "F", "G"], list(self.store.toy_shelf.keys()))
		self.assertIsNone(self.store.toy_shelf["A"])
		self.assertIsNone(self.store.toy_shelf["B"])
		self.assertIsNone(self.store.toy_shelf["C"])
		self.assertIsNone(self.store.toy_shelf["D"])
		self.assertIsNone(self.store.toy_shelf["E"])
		self.assertIsNone(self.store.toy_shelf["F"])
		self.assertIsNone(self.store.toy_shelf["G"])

	def test_add_toy_raises_exception_if_shelf_is_invalid(self):
		with self.assertRaises(Exception) as ex:
			self.store.add_toy("Z", "Marvin")
		self.assertEqual("Shelf doesn't exist!", str(ex.exception))

	def test_add_toy_raises_exception_if_toy_is_on_the_shelf(self):
		self.store.toy_shelf["A"] = "Marvin"
		with self.assertRaises(Exception) as ex:
			self.store.add_toy("A", "Marvin")
		self.assertEqual("Toy is already in shelf!", str(ex.exception))

	def test_add_toy_raises_exception_if_shelf_is_taken(self):
		self.store.toy_shelf["A"] = "Marvin"
		with self.assertRaises(Exception) as ex:
			self.store.add_toy("A", "Zaphod")
		self.assertEqual("Shelf is already taken!", str(ex.exception))

	def test_add_toy_is_successful(self):
		result = self.store.add_toy("A", "Marvin")
		self.assertEqual("Toy:Marvin placed successfully!", result)
		self.assertEqual("Marvin", self.store.toy_shelf["A"])

	def test_remove_toy_raises_exception_if_shelf_name_is_invalid(self):
		with self.assertRaises(Exception) as ex:
			self.store.remove_toy("Z", "Marvin")
		self.assertEqual("Shelf doesn't exist!", str(ex.exception))

	def test_remove_toy_raises_exception_if_toy_is_not_on_the_shelf(self):
		self.store.add_toy("A", "Zaphod")

		with self.assertRaises(Exception) as ex:
			self.store.remove_toy("A", "Marvin")
		self.assertEqual("Toy in that shelf doesn't exists!", str(ex.exception))

	def test_remove_toy_is_successful(self):
		self.store.add_toy("A", "Marvin")
		result = self.store.remove_toy("A", "Marvin")
		self.assertEqual("Remove toy:Marvin successfully!", result)
		self.assertIsNone(self.store.toy_shelf["A"])


if __name__ == "__main__":
	main()
