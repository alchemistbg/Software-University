# 100/100

animals = input().split(', ')
animals.reverse()

wolf_idx = animals.index('wolf')

if wolf_idx == 0:
    print('Please go away and stop eating my sheep')
else:
    print(f'Oi! Sheep number {wolf_idx}! You are about to be eaten by a wolf!')

# Old solution for this problem
# string = input()
#
# animals = string.split(', ')
# animals.reverse()
#
# if animals[0] == "wolf":
#     print("Please go away and stop eating my sheep")
# else:
#     for i in range(1, len(animals)):
#         if animals[i] == "wolf":
#             print(f"Oi! Sheep number {i}! You are about to be eaten by a wolf!")
