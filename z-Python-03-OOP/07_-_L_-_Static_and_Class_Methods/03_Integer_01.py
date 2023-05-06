import math


class Integer:

    def __init__(self, value: int):
        self.value = value

    @classmethod
    def from_float(cls, value: float):
        if not isinstance(value, float):
            return "value is not a float"

        n = math.floor(value)
        return cls(n)

    @classmethod
    def from_roman(cls, value: str):
        return cls(0)

    @classmethod
    def from_string(cls, value: str):
        value = str(value)
        if not value.isnumeric():
            return "wrong type"

        n = int(value)
        return cls(n)

    def add(self, i):
        if not isinstance(i, Integer):
            return f"number should be an Integer instance"

        return self.value + i.value


first_num = Integer(10)
print(first_num.value)

# second_num = Integer.from_roman("IV")
second_num = Integer.from_float(2.6)
print(second_num.value)
print(first_num.add(5))

print(Integer.from_float("2.6"))
print(Integer.from_string(2.6))

