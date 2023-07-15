from copy import copy


def possible_permutations(seq):
	def recurse(seq, idx = 0, perm = None, used = None):
		if perm is None:
			perm = [0] * len(seq)

		if used is None:
			used = [False] * len(seq)

		if idx == len(seq):
			yield copy(perm)
			return

		for i, x in enumerate(seq):
			if not used[i]:
				perm[idx] = x
				used[i] = True
				yield from recurse(seq, idx + 1, perm, used)
				used[i] = False
	return recurse(seq, idx = 0, perm = None, used = None)

print(list(possible_permutations([1, 2, 3, 4])))
