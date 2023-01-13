# 100/100

type = input()
rows = int(input())
cols = int(input())

seats = rows * cols

profit = 0
if type == "Premiere":
    profit = seats * 12
elif type == "Normal":
    profit = seats * 7.5
elif type == "Discount":
    profit = seats * 5

print(f"{profit:.2f} leva")

