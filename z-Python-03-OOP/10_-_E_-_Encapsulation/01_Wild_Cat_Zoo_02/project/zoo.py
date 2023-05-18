class Zoo:
    def __init__(self, name: str, budget: int, animals_capacity: int, workers_capacity: int):
        self.name = name
        self.__budget = budget
        self.animals_capacity = animals_capacity
        self.__workers_capacity = workers_capacity
        self.animals = []
        self.workers = []

    def add_animal(self, animal, price):
        if len(self.animals) < self.__animal_capacity and self.budget >= animal.get_needs():
            self.animals.append(animal)
            self.budget -= price
            animal_type = self.__get_type_as_str(animal)
            return f"{animal.name} the {animal_type} added to the zoo"
        elif len(self.animals) < self.__animal_capacity and self.budget < animal.get_needs():
            return "Not enough budget"
        else:
            return "Not enough space for animal"
