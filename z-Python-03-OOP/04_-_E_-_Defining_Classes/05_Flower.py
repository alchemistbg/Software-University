# 100/100

# Solution with a usual class
# class Flower:
#
#     def __init__(self, name: str, water_requirements: int):
#         self.name = name
#         self.water_requirements = water_requirements
#         self.is_happy = False
#
#     def water(self, quantity: int):
#         # if self.water_requirements <= quantity:
#         #     self.is_happy = True
#         # The above if statement could be rewritten as:
#         self.is_happy = self.water_requirements <= quantity
#
#     def status(self):
#         if self.is_happy:
#             return f"{self.name} is happy"
#         return f"{self.name} is not happy"

# Solution with a dataclass
from dataclasses import dataclass


@dataclass
class Flower:
    name: str
    water_requirements: int
    is_happy: bool = False

    def water(self, quantity: int):
        # if self.water_requirements <= quantity:
        #     self.is_happy = True
        # The above if statement could be rewritten as:
        self.is_happy = self.water_requirements <= quantity

    def status(self):
        if self.is_happy:
            return f"{self.name} is happy"
        return f"{self.name} is not happy"


flower = Flower("Lilly", 100)
flower.water(50)
print(flower.status())
flower.water(60)
print(flower.status())
flower.water(100)
print(flower.status())
