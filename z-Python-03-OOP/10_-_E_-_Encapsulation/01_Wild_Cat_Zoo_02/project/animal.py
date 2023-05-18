class Animal:
    def __init__(self, name: str, gender: str, age: int, money_for_care: int = 0):
        self.name = name
        self.gender = gender
        self.age = age

    @property
    def money_for_care(self):
        class_type = str(self.__class__)
        if 'Lion' in class_type:
            return 50
        elif 'Tiger' in class_type:
            return 45
        elif 'Cheetah' in class_type:
            return 60
        else:
            return 0


    def __repr__(self):
        return f"Name: {self.name}, Age: {self.age}, Gender: {self.gender}"

