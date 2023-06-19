from project.animals.birds import Owl
from project.food import Meat
from project.food import Vegetable

owl = Owl("Pip", 10, 10)
print(owl)
meat = Meat(4)
print(owl.make_sound())
owl.feed(meat)
veg = Vegetable(1)
print(owl.feed(veg))
print(owl)


# first zero test
# import unittest
# from project.animals.birds import Owl, Hen
# from project.animals.mammals import Mouse, Dog, Cat, Tiger
# from project.food import Vegetable, Fruit, Meat, Seed
#
#
# class WildFarmTests(unittest.TestCase):
#     def test_first_zero(self):
#         mouse = Mouse("Pip", 10, "Home")
#         self.assertEqual(str(mouse), "Mouse [Pip, 10, Home, 0]")
#         print(mouse)
#         self.assertEqual(mouse.make_sound(), "Squeak")
#         meat = Meat(4)
#         mouse.feed(meat)
#         veg = Vegetable(10)
#         mouse.feed(veg)
#         self.assertEqual(mouse.feed(meat), "Mouse does not eat Meat!")
#         self.assertEqual(str(mouse), "Mouse [Pip, 11.0, Home, 10]")
#
#
# if __name__ == "__main__":
#     unittest.main()

# second zero test
# import unittest
# from project.animals.birds import Owl, Hen
# from project.animals.mammals import Mouse, Dog, Cat, Tiger
# from project.food import Vegetable, Fruit, Meat, Seed
#
#
# class WildFarmTests(unittest.TestCase):
#     def test_second_zero(self):
#         hen = Hen("Harry", 10, 10)
#         veg = Vegetable(3)
#         fruit = Fruit(5)
#         meat = Meat(1)
#         self.assertEqual(str(hen), "Hen [Harry, 10, 10, 0]")
#         self.assertEqual(hen.make_sound(), "Cluck")
#         hen.feed(veg)
#         hen.feed(fruit)
#         hen.feed(meat)
#         self.assertEqual(str(hen), "Hen [Harry, 10, 13.15, 9]")
#
#
# if __name__ == "__main__":
#     unittest.main()
