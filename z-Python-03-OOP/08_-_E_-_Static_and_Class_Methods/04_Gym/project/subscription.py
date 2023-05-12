from itertools import count


class Subscription:
    id = count(start = 1)

    def __init__(self, date: str, customer_id: int, trainer_id: int, exercise_id: int):
        self.date = date
        self.customer_id = customer_id
        self.trainer_id = trainer_id
        self.exercise_id = exercise_id
        self.id = Subscription.get_next_id()

    @staticmethod
    def get_next_id():
        return next(Subscription.id)

    def __repr__(self):
        return f"Subscription <{self.id}> on {self. date}"
