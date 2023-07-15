from itertools import permutations


def possible_permutations(sequence):
	return (list(permutation) for permutation in permutations(sequence))


[print(n) for n in possible_permutations([1, 2, 3])]
