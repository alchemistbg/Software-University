from itertools import count


class Equipment:
    id = count(start = 1)

    def __init__(self, name: str):
        self.name = name
        self.id = Equipment.get_next_id()

    @staticmethod
    def get_next_id():
        return next(Equipment.id)

    def __repr__(self):
        return f"Equipment <{self.id}> {self.name}"
