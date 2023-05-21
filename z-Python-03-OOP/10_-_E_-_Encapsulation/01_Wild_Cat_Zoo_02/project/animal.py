class Animal:

    def __init__(self, name: str, gender: str, age: int, money_for_care: int = 0):
        self.name = name
        self.gender = gender
        self.age = age

    def __repr__(self):
        return f"Name: {self.name}, Age: {self.age}, Gender: {self.gender}"

