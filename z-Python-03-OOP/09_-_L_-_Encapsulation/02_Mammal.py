# 100/100

class Mammal:
    __kingdom = "animals"

    def __init__(self, name: str, type: str, sound: str):
        self.name = name
        self.type = type
        self.sound = sound

    def make_sound(self) -> str:
        return f"{self.name} makes {self.sound}"

    # This must be instance method (according problem descriptions)
    def get_kingdom(self) -> str:
        # One way
        return self.__kingdom
        # Another way
        # return Mammal.__kingdom

    # This is a third way for achieving the upper functionality
    # @classmethod
    # def get_kingdom(cls) -> str:
    #     return cls.__kingdom

    def info(self):
        return f'{self.name} is of type {self.type}'


mammal = Mammal("Dog", "Domestic", "Bark")
print(mammal.make_sound())
print(mammal.get_kingdom())
print(mammal.info())
