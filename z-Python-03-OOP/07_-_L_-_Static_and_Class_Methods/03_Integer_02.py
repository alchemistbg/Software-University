import math


class Integer:

    def __init__(self, value: int):
        self.value = value

    @classmethod
    def from_float(cls, f: float):
        if not isinstance(f, float):
            return "value is not a float"

        n = math.floor(f)
        return cls(n)

    @classmethod
    def from_roman(cls, s):
        return cls(0)

    @classmethod
    def from_string(cls, s: str):
        s = str(s)
        if not s.isnumeric():
            return "wrong type"

        n = int(s)
        return cls(n)


first_num = Integer(10)
print(first_num.value)

# second_num = Integer.from_roman("IV")
second_num = Integer.from_float(2.6)
print(second_num.value)

print(Integer.from_float("2.6"))
print(Integer.from_string(2.6))

