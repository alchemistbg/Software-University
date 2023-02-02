# 100/100

pokemons = [int(n) for n in input().split()]

score = 0


def manipulate_pokemons(pokemon, pokemons):
    for idx in range(len(pokemons)):
        if pokemons[idx] <= pokemon:
            pokemons[idx] += pokemon
            continue

        pokemons[idx] -= pokemon

    return pokemons


while len(pokemons) > 0:
    idx = int(input())
    if idx < 0:
        pokemon = pokemons.pop(0)
        pokemons.insert(0, pokemons[-1])
    elif idx > len(pokemons) - 1:
        pokemon = pokemons.pop()
        pokemons.append(pokemons[0])
    else:
        pokemon = pokemons.pop(idx)

    score += pokemon

    pokemons = manipulate_pokemons(pokemon, pokemons)

print(score)
