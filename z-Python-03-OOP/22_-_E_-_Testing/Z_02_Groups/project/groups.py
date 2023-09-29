class Person:
    def __init__(self, name: str, surname: str):
        self.name = name
        self.surname = surname

    def __add__(self, other):
        return Person(self.name, other.surname)

    def __str__(self):
        return f'{self.name} {self.surname}'


class Group:
    def __init__(self, name: str, people):
        self.name = name
        self.people = people

    def __add__(self, other):
        return Group(self.name + other.name, self.people + other.people)

    def __len__(self):
        return len(self.people)

    def __getitem__(self, ind):
        return f'Person {ind}: {self.people[ind]}'

    def __str__(self):
        return f'Group {self.name} with members {", ".join(str(x) for x in self.people)}'