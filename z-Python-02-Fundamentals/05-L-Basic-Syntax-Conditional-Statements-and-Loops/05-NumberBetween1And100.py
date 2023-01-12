# 100/100

number = float(input())

while True:
    if number >= 1 and number <= 100:
        print(f"The number {number} is between 1 and 100")
        break
    else:
        number = float(input())
