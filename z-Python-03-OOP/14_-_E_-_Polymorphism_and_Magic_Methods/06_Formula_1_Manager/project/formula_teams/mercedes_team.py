from project.formula_teams.formula_team import FormulaTeam


class MercedesTeam(FormulaTeam):

    _RACE_COST = 200_000
    _SPONSORS_PRICES = {
        1: 1_100_000,
        3: 600_000,
        5: 100_000,
        7: 50_000,
    }
