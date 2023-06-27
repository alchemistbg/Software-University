from project.formula_teams.formula_team import FormulaTeam


class RedBullTeam(FormulaTeam):

    _RACE_COST = 250_000
    _SPONSORS_PRICES = {
        1: 1_520_000,
        2: 820_000,
        8: 20_000,
        10: 10_000,
    }
