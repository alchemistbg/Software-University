class Pokemon:
    def __init__(self, name: str, health: int):
        self.name = name
        self.health = health

    # This method is predefined by me in order to check pokemon just by name
    # This is not so good approach
    # The lecturer uses another approach with strings
    # def __eq__(self, another_pokemon) -> bool:
    #     return self.name == another_pokemon

    def pokemon_details(self) -> str:
        return f"{self.name} with health {self.health}"
