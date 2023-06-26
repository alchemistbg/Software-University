# from project.formula_teams.formula_team import FormulaTeam


# class MercedesTeam(FormulaTeam):
#
# 	def __init__(self, budget: int):
# 		super().__init__(budget)
#
# 	def calculate_revenue_after_race(self, race_pos: int):
# 		revenue = 0
# 		if race_pos == 1:
# 			revenue = 1100000
# 		elif race_pos == 2:
# 			revenue = 600000
# 		elif race_pos == 5:
# 			revenue = 100000
# 		elif race_pos == 7:
# 			revenue = 50000
# 		revenue -= 200000
# 		self.budget += revenue
# 		return f"The revenue after the race is {revenue}$. Current budget {self.budget}$"

from project.formula_teams.formula_team import FormulaTeam

class MercedesTeam(FormulaTeam):
    EXPENSES_PER_RACE = 200_000

    def __init__(self, budget: int):
        super().__init__(budget)

    def calculate_revenue_after_race(self, race_pos: int):
        sponsors_dict = {1: 1_100_000, 3: 600_000, 5: 100_000, 7: 50_000}
        revenue = sponsors_dict.get(race_pos, 0) - MercedesTeam.EXPENSES_PER_RACE
        self.budget += revenue

        return f"The revenue after the race is {revenue}$. Current budget {self.budget}$"
