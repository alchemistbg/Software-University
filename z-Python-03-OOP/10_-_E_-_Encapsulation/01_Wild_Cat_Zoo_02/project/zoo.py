from typing import List
from .animal import Animal
from .worker import Worker


class Zoo:
    def __init__(self, name: str, budget: int, animals_capacity: int, workers_capacity: int):
        self.name = name
        self.__budget = budget
        self.__animal_capacity = animals_capacity
        self.__workers_capacity = workers_capacity
        self.animals: List[Animal] = []
        self.workers: List[Worker] = []

    @staticmethod
    def __get_type_as_str(t) -> str:
        start_idx = str(type(t)).rindex('.') + 1
        end_idx = str(type(t)).rindex('\'')
        type_as_str = str(type(t))[start_idx:end_idx]
        return type_as_str

    def add_animal(self, animal: Animal, price: float) -> str:
        if len(self.animals) < self.__animal_capacity and self.__budget >= price:
            self.animals.append(animal)
            self.__budget -= price
            animal_type = self.__get_type_as_str(animal)
            return f"{animal.name} the {animal_type} added to the zoo"
        elif len(self.animals) < self.__animal_capacity and self.__budget < price:
            return "Not enough budget"
        else:
            return "Not enough space for animal"

    def hire_worker(self, worker: Worker) -> str:
        if len(self.workers) < self.__workers_capacity:
            self.workers.append(worker)
            worker_type = self.__get_type_as_str(worker)
            return f"{worker.name} the {worker_type} hired successfully"
        return "Not enough space for worker"

    def fire_worker(self, worker_name) -> str:
        worker = [w for w in self.workers if w.name == worker_name]
        if worker:
            self.workers.remove(worker[0])
            return f"{worker_name} fired successfully"
        return f"There is no {worker_name} in the zoo"

    def pay_workers(self) -> str:
        total_salaries = sum([w.salary for w in self.workers])
        if self.__budget >= total_salaries:
            self.__budget -= total_salaries
            return f"You payed your workers. They are happy. Budget left: {self.__budget}"
        return "You have no budget to pay your workers. They are unhappy"

    def tend_animals(self) -> str:
        total_tend = sum([a.money_for_care for a in self.animals])
        if self.__budget >= total_tend:
            self.__budget -= total_tend
            return f"You tended all the animals. They are happy. Budget left: {self.__budget}"
        return "You have no budget to tend the animals. They are unhappy."

    def profit(self, amount):
        self.__budget += amount

    def animals_status(self) -> str:
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

    def workers_status(self) -> str:
        output = ""
        title = f"You have {len(self.workers)} workers\n"
        output += title

        keepers = [w for w in self.workers if self.__get_type_as_str(w) == "Keeper"]
        output += f"----- {len(keepers)} Keepers:\n"
        output += "\n".join(map(str, keepers))

        caretakers = [w for w in self.workers if self.__get_type_as_str(w) == "Caretaker"]
        output += f"\n----- {len(caretakers)} Caretakers:\n"
        output += "\n".join(map(str, caretakers))

        vets = [w for w in self.workers if self.__get_type_as_str(w) == "Vet"]
        output += f"\n----- {len(vets)} Vets:\n"
        output += "\n".join(map(str, vets))

        return output
