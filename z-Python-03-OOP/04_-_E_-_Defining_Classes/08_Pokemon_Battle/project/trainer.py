class Trainer:
    def __init__(self, name: str):
        self.name = name
        self.pokemons = []

    def add_pokemon(self, pokemon) -> str:
        if pokemon in self.pokemons:
            return f"This pokemon is already caught"
        self.pokemons.append(pokemon)
        return f"Caught {pokemon.pokemon_details()}"

    # This variant of the release method could be used if __eq__ method is predefined
    # def release_pokemon(self, pokemon_name) -> str:
    #     if pokemon_name not in self.pokemons:
    #         return "Pokemon is not caught"
    #
    #     self.pokemons.remove(pokemon_name)
    #     return f"You have released {pokemon_name}"

    # This variant of the release method was used by the lecturer
    def release_pokemon(self, pokemon_name) -> str:
        pokemon_names = [pokemon.name for pokemon in self.pokemons]
        if pokemon_name not in pokemon_names:
            return "Pokemon is not caught"

        pokemon_name_idx = pokemon_names.index(pokemon_name)
        del self.pokemons[pokemon_name_idx]
        return f"You have released {pokemon_name}"

    def trainer_data(self) -> str:
        trainer_info = [
            f"Pokemon Trainer {self.name}",
            f"Pokemon count {len(self.pokemons)}"
        ]
        pokemons_info = [f'- {pokemon.pokemon_details()}' for pokemon in self.pokemons]
        return "\n".join(trainer_info + pokemons_info)
