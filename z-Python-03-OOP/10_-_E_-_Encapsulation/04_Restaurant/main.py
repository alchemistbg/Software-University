# zero test
from project.product import Product
from project.beverage.beverage import Beverage
from project.beverage.coffee import Coffee
# from project.beverage.tea import Tea
from project.food.soup import Soup
from project.food.salmon import Salmon
from project.food.dessert import Dessert
from project.food.cake import Cake
import unittest


class Tests(unittest.TestCase):
    def test_product_class(self):
        product = Product("coffee", 2.5)
        self.assertEqual(product.__class__.__name__, "Product")
        self.assertEqual(product.name, "coffee")
        self.assertEqual(product.price, 2.5)

    def test_beverage_class(self):
        beverage = Beverage("coffee", 2.5, 50)
        self.assertEqual(beverage.__class__.__name__, "Beverage")
        self.assertEqual(beverage.__class__.__bases__[0].__name__, "Product")
        self.assertEqual(beverage.name, "coffee")
        self.assertEqual(beverage.price, 2.5)
        self.assertEqual(beverage.milliliters, 50)

    def test_coffee_class(self):
        coffee = Coffee("coffee", 2.5)

    def test_food_class(self):
        soup = Soup("fish soup", 9.90, 230)
        self.assertEqual(soup.__class__.__name__, "Soup")
        self.assertEqual(soup.__class__.__bases__[0].__name__, "Starter")
        self.assertEqual(soup.name, "fish soup")
        self.assertEqual(soup.price, 9.90)
        self.assertEqual(soup.grams, 230)

        dessert = Dessert("desert", 10, 10, 10)
        self.assertEqual(dessert.__class__.__name__, "Dessert")
        self.assertEqual(dessert.__class__.__bases__[0].__name__, "Food")

        cake = Cake("cake")
        print(cake.__dict__)

        salmon = Salmon("salmon", 20)
        print(salmon.__dict__)

if __name__ == "__main__":
    unittest.main()


# from project.product import Product
# from project.beverage.beverage import Beverage
# from project.food.soup import Soup
#
# product = Product("coffee", 2.5)
# print(product.__class__.__name__)
# print(product.name)
# print(product.price)
#
# beverage = Beverage("coffee", 2.5, 50)
# print(beverage.__class__.__name__)
# print(beverage.__class__.__bases__[0].__name__)
# print(beverage.name)
# print(beverage.price)
# print(beverage.milliliters)
#
# soup = Soup("fish soup", 9.90, 230)
# print(soup.__class__.__name__)
# print(soup.__class__.__bases__[0].__name__)
# print(soup.name)
# print(soup.price)
# print(soup.grams)
