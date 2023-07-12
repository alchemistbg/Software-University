# 1st solution
# def reverse_text(string: str):
# 	i = len(string)
# 	while i > 0:
# 		i -= 1
# 		yield string[i]


# 2nd solution
def reverse_text(string: str):
	yield string[::-1]


for char in reverse_text("step"):
	print(char, end='')
