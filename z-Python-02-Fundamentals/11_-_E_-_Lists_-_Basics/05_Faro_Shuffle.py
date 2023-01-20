# 100/100
# This solution is based on the following article:
# https://towardsdatascience.com/the-perfect-shuffle-aa388ad1ffd1
# It contains a ready-to-use formula for calculating faro shuffle.
# This allows using of just one for loop!

deck = input().split(' ')
iterations = int(input())

deck_variable = len(deck) - 1
shuffled_deck = deck[:]

for idx in range(1, deck_variable):
    new_idx = (2 ** iterations) * idx % (deck_variable)
    shuffled_deck[new_idx] = deck[idx]

print(shuffled_deck)

# This solution is based on the lector's explanation. It uses two nested for loops.
# deck = input().split(' ')
# iterations = int(input())
#
# deck_full_length = len(deck)
# deck_half_length = deck_full_length // 2
#
# for i in range(iterations):
#
#     shuffled_deck = []
#
#     for idx in range(deck_half_length):
#         first_card = deck[idx]
#         second_card = deck[idx + deck_half_length]
#
#         shuffled_deck.append(first_card)
#         shuffled_deck.append(second_card)
#
#     deck = shuffled_deck
#
# print(shuffled_deck)
