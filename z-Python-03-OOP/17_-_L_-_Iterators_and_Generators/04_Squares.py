# 1st solution
# def squares(n):
# 	for i in range(1, n + 1):
# 		yield i * i


# 2nd solution
# def squares(n):
# 	i = 1
# 	while i <= n:
# 		yield i * i
# 		i += 1

# 3rd solution
squares = lambda n: (i ** 2 for i in range(1, n + 1))


print(list(squares(5)))

