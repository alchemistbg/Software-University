# from project.formula_teams.formula_team import FormulaTeam


# class RedBullTeam(FormulaTeam):
#
# 	def __init__(self, budget: int):
# 		super().__init__(budget)
#
# 	def calculate_revenue_after_race(self, race_pos: int):
# 		revenue = 0
# 		if race_pos == 1:
# 			revenue = 1520000
# 		elif race_pos == 2:
# 			revenue = 820000
# 		elif race_pos == 8:
# 			revenue = 20000
# 		elif race_pos == 10:
# 			revenue = 10000
# 		revenue -= 250000
# 		self.budget += revenue
# 		return f"The revenue after the race is {revenue}$. Current budget {self.budget}$"

from project.formula_teams.formula_team import FormulaTeam

class RedBullTeam(FormulaTeam):
    EXPENSES_PER_RACE = 250_000

    def __init__(self, budget: int):
        super().__init__(budget)

    def calculate_revenue_after_race(self, race_pos: int):
        sponsors_dict = {1: 1_520_000, 2: 820_000, 8: 20_000, 10: 10_000}
        revenue = sponsors_dict.get(race_pos, 0) - RedBullTeam.EXPENSES_PER_RACE
        self.budget += revenue

        return f"The revenue after the race is {revenue}$. Current budget {self.budget}$"
