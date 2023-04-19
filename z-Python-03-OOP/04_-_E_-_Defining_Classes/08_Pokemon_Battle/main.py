# 100/100
# This main file was created to test the objects

from project.pokemon import Pokemon
from project.trainer import Trainer

if __name__ == "__main__":
    pokemon = Pokemon("Pikachu", 90)
    print(pokemon.pokemon_details())
    trainer = Trainer("Ash")
    print(trainer.add_pokemon(pokemon))
    second_pokemon = Pokemon("Charizard", 110)
    print(trainer.add_pokemon(second_pokemon))
    print(trainer.add_pokemon(second_pokemon))
    print(trainer.release_pokemon("Pikachu"))
    print(trainer.release_pokemon("Pikachu"))
    third_pokemon = Pokemon("Gancho", 160)
    print(trainer.add_pokemon(third_pokemon))
    fourth_pokemon = Pokemon("Pencho", 160)
    print(trainer.add_pokemon(fourth_pokemon))
    print(trainer.trainer_data())