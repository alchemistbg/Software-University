
# 1st solution
# def genrange(start, end):
# 	for i in range(start, end + 1):
# 		yield i

# 2nd solution
# def genrange(start, end):
# 	while start <= end:
# 		yield start
# 		start += 1

# 3rd solution
genrange = lambda start, end: (i for i in range(start, end + 1))

print(list(genrange(1, 10)))
