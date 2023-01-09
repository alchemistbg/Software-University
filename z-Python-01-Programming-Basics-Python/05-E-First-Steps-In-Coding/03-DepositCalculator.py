# 100/100

deposit = float(input())
duration = int(input())
interest = float(input())/100
profit = deposit + (duration * ((deposit*interest)/12))
print(profit)
