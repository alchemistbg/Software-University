class Zoo:
    def __init__(self, name: float, budget: float, animal_capacity: int, workers_capacity: int):
        self.__animal_capacity = animal_capacity
        self.__workers_capacity = workers_capacity
        self.name = name
        self.budget = budget
        self.animals = []
        self.workers = []

    @staticmethod
    def __get_type_as_str(t):
        start_idx = str(type(t)).rindex('.') + 1
        end_idx = str(type(t)).rindex('\'')
        type_as_str = str(type(t))[start_idx:end_idx]
        return type_as_str

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

    def hire_worker(self, worker):
        if len(self.workers) < self.__workers_capacity:
            self.workers.append(worker)
            worker_type = self.__get_type_as_str(worker)
            return f"{worker.name} the {worker_type} hired successfully"
        return "Not enough space for worker"

    def fire_worker(self, worker_name):
        worker = [w for w in self.workers if w.name == worker_name]
        if worker:
            self.workers.remove(worker[0])
            return f"{worker_name} fired successfully"
        return f"There is no {worker_name} in the zoo"

    def pay_workers(self):
        total_salaries = sum([w.salary for w in self.workers])
        if self.budget >= total_salaries:
            self.budget -= total_salaries
            return f"You payed your workers. They are happy. Budget left: {self.budget}"

    def tend_animals(self):
        total_tend = sum([a.get_needs() for a in self.animals])
        if self.budget >= total_tend:
            self.budget -= total_tend
            return f"You tended all the animals. They are happy. Budget left: {self.budget}"
        return "You have no budget to tend the animals. They are unhappy."

    def profit(self, amount):
        self.budget += amount

    def animals_status(self):
        output = ""
        title = f"You have {len(self.animals)} animals\n"
        output += title

        lions = [a for a in self.animals if self.__get_type_as_str(a) == "Lion"]
        output += f"----- {len(lions)} Lions:\n"
        output += "\n".join(map(str, lions))

        tigers = [a for a in self.animals if self.__get_type_as_str(a) == "Tiger"]
        output += f"\n----- {len(tigers)} Tigers:\n"
        output += "\n".join(map(str, tigers))

        cheetah = [a for a in self.animals if self.__get_type_as_str(a) == "Cheetah"]
        output += f"\n----- {len(cheetah)} Cheetahs:\n"
        output += "\n".join(map(str, cheetah))

        return output

    def workers_status(self):
        output = ""
        title = f"You have {len(self.workers)} workers\n"
        output += title

        keepers = [w for w in self.workers if self.__get_type_as_str(w) == "Keeper"]
        output += f"----- {len(keepers)} Keeper:\n"
        output += "\n".join(map(str, keepers))

        caretakers = [w for w in self.workers if self.__get_type_as_str(w) == "Caretaker"]
        output += f"\n----- {len(caretakers)} Caretakers:\n"
        output += "\n".join(map(str, caretakers))

        vets = [w for w in self.workers if self.__get_type_as_str(w) == "Vet"]
        output += f"\n----- {len(vets)} Vets:\n"
        output += "\n".join(map(str, vets))

        return output

