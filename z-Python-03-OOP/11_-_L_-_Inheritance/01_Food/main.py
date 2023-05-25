# 100/100

import unittest

from project.food import Food
from project.fruit import Fruit


class FoodTests(unittest.TestCase):
    def test_food_class(self):
        exp_date = "23.12.23"
        f = Food(exp_date)
        self.assertEqual(f.expiration_date, exp_date)


if __name__ == "__main__":
    unittest.main()