# 100/100

from collections import deque

bombs = {
    'Cherry Bombs': {'Effect': 60, 'Qty': 0},
    'Datura Bombs': {'Effect': 40, 'Qty': 0},
    'Smoke Decoy Bombs': {'Effect': 120, 'Qty': 0},
}

effects = deque(map(int, input().split(', ')))
casings = deque(map(int, input().split(', ')))

success = True

while True:
    if not effects or not casings:
        success = False
        break

    effect = effects[0]
    casing = casings[-1]
    bomb = effect + casing

    bombs_effects = [bomb_data['Effect'] for bomb_data in bombs.values()]
    bombs_qty = [True if bomb_data['Qty'] >= 3 else False for bomb_data in bombs.values()]

    if all(bombs_qty):
        break

    if bomb in bombs_effects:
        effects.popleft()
        casings.pop()
        bomb_type = list(bombs.keys())[bombs_effects.index(bomb)]
        bombs[bomb_type]['Qty'] += 1
    else:
        casings[-1] -= 5

if success:
    print("Bene! You have successfully filled the bomb pouch!")
else:
    print("You don't have enough materials to fill the bomb pouch.")

if effects:
    print(f"Bomb Effects: {', '.join(map(str, effects))}")
else:
    print(f"Bomb Effects: empty")

if casings:
    print(f"Bomb Casings: {', '.join(map(str, casings))}")
else:
    print(f"Bomb Casings: empty")

[print(f'{bomb_type}: {bomb_data["Qty"]}') for bomb_type,bomb_data in bombs.items()]
