# 100/100

def get_info(**kwargs):
    return f"This is {kwargs['name']} from {kwargs['town']} and he is {kwargs['age']} years old"

person_data = {"name": "George", "town": "Sofia", "age": 20}
person_info = get_info(**person_data)
print(person_info)