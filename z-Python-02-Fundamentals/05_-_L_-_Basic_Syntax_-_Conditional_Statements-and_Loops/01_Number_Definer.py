# 100/100

number = float(input())

if number == 0:
    print("zero")

if number != 0 and abs(number) < 1:
    print("small", end=" ")

if abs(number) > 1000000:
    print("large", end=" ")

if number < 0:
    print("negative")

if number > 0:
    print("positive")
