l = [1, 2, 3, 4, 5]

iterator = iter(l)
while True:
	try:
		i = next(iterator)
		print(i)
	except StopIteration:
		break
