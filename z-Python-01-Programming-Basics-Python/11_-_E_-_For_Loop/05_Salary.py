# 100/100

tabsCount = int(input())
salary = int(input())

for i in range(0, tabsCount):
    site = input()
    fine = 0
    if site == "Facebook":
        fine = 150
    elif site == "Instagram":
        fine = 100
    elif site == "Reddit":
        fine = 50

    salary -= fine

    if salary <= 0:
        print("You have lost your salary.")
        break
else:
    print(salary)
