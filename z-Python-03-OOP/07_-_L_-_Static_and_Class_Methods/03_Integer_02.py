# 100/100

class Integer:

    def __init__(self, value: int):
        self.value = value

    @classmethod
    def from_float(cls, value: float):
        if not isinstance(value, float):
            return "value is not a float"

        n = int(value)
        return cls(n)

    @classmethod
    def from_roman(cls, value):
        roman = {'I': 1,
                 'V': 5,
                 'X': 10,
                 'L': 50,
                 'C': 100,
                 'D': 500,
                 'M': 1000,
                 'IV': 4,
                 'IX': 9,
                 'XL': 40,
                 'XC': 90,
                 'CD': 400,
                 'CM': 900
                 }
        i = 0
        n = 0
        while i < len(value):
            if i + 1 < len(value) and value[i:i + 2] in roman.keys():
                n += roman[value[i:i + 2]]
                i += 2
            else:
                n += roman[value[i]]
                i += 1
        return cls(n)

    @classmethod
    def from_string(cls, s: str):
        s = str(s)
        if not s.isnumeric():
            return "wrong type"

        n = int(s)
        return cls(n)


first_num = Integer(10)
print(first_num.value)

second_num = Integer.from_roman("IV")
print(second_num.value)

print(Integer.from_float("2.6"))
print(Integer.from_string(2.6))

