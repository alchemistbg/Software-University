from project.factory.paint_factory import PaintFactory

from unittest import TestCase, main


class PaintFactoryTests(TestCase):

	def setUp(self):
		self.factory = PaintFactory("Factory", 10)

	def test_paint_factory_is_initialize_correctly(self):
		self.assertEqual("Factory", self.factory.name)
		self.assertEqual(10, self.factory.capacity)
		self.assertEqual({}, self.factory.ingredients)
		self.assertEqual({}, self.factory.products)

		self.assertEqual(["white", "yellow", "blue", "green", "red"], self.factory.valid_ingredients)

	def test_products_property(self):
		self.factory.add_ingredient("white", 10)
		self.assertEqual({'white': 10}, self.factory.products)

	def test_add_ingredient_raise_type_error_when_ingredient_is_invalid(self):
		with self.assertRaises(TypeError) as ex:
			self.factory.add_ingredient("black", 10)

		self.assertEqual("Ingredient of type black not allowed in PaintFactory", str(ex.exception))

	def test_add_ingredient_raise_value_error_when_ingredient_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.factory.add_ingredient("white", 1000)

		self.assertEqual("Not enough space in factory", str(ex.exception))

	def test_add_ingredient_if_ingredient_is_valid(self):
		self.factory.add_ingredient("white", 10)
		self.assertEqual(10, self.factory.ingredients['white'])

	def test_remove_ingredient_raise_key_error_when_product_type_not_in_ingredients(self):
		with self.assertRaises(KeyError) as ex:
			self.factory.remove_ingredient("white", 10)

		self.assertEqual("'No such ingredient in the factory'", str(ex.exception))

	def test_remove_ingredient_raise_value_error_when_product_qty_is_bigger_than_it_is_in_ingredients(self):
		self.factory.add_ingredient("white", 10)
		with self.assertRaises(ValueError) as ex:
			self.factory.remove_ingredient("white", 100)

		self.assertEqual("Ingredients quantity cannot be less than zero", str(ex.exception))

	def test_remove_ingredient_data_is_valid(self):
		self.factory.add_ingredient("white", 10)
		self.factory.remove_ingredient("white", 5)
		self.assertEqual(5, self.factory.ingredients['white'])


if __name__ == "__main__":
	main()
