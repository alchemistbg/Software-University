from abc import ABC, abstractmethod


class FormulaTeam(ABC):

    def __init__(self, budget):
        self.budget = budget

    @property
    def budget(self):
        return self.__budget

    @budget.setter
    def budget(self, value):
        if value < 1_000_000:
            raise ValueError('F1 is an expensive sport, find more sponsors!')
        self.__budget = value

    @property
    @abstractmethod
    def _RACE_COST(self):
        ...

    @property
    @abstractmethod
    def _SPONSORS_PRICES(self):
        ...

    def calculate_revenue_after_race(self, race_pos: int):
        profit = 0
        if race_pos in self._SPONSORS_PRICES.keys():
            profit = self._SPONSORS_PRICES[race_pos]

        revenue = profit - self._RACE_COST
        self.budget += revenue
        return f"The revenue after the race is {revenue}$. Current budget {self.budget}$"
