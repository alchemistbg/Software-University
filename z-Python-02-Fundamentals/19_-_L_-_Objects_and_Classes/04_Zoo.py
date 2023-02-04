# 100/100

class Zoo:
    __animals = 0

    def __init__(self, name):
        self.name = name
        self.mammals = []
        self.fishes = []
        self.birds = []

    def add_animal(self, species, name):
        self.__animals += 1
        if species == 'mammal':
            self.mammals.append(name)
        elif species == 'bird':
            self.birds.append(name)
        elif species == 'fish':
            self.fishes.append(name)

    def get_info(self, species):
        if species == 'mammal':
            return f'Mammals in {self.name}: {", ".join(self.mammals)}'
        elif species == 'bird':
            return f'Birds in {self.name}: {", ".join(self.birds)}'
        elif species == 'fish':
            return f'Fishes in {self.name}: {", ".join(self.fishes)}'

    def get_animal_count(self):
        return f'Total animals: {self.__animals}'


zoo_name = input()
zoo = Zoo(zoo_name)

lines = int(input())

for _ in range (0, lines):
    species, name = input().split()
    zoo.add_animal(species, name)

query = input()
print(zoo.get_info(query))
print(zoo.get_animal_count())
