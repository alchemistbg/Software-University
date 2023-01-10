# 100/100

fruit = input()
day = input()
qty = float(input())

totalPrice = 0

weekdays = "Monday, Tuesday, Wednesday, Thursday, Friday"
weekends = "Saturday, Sunday"
fruits = "banana, apple, orange, grapefruit, kiwi, pineapple, grapes"

fruitsWeekday = {'banana': 2.50, 'apple': 1.20, 'orange': 0.85, 'grapefruit': 1.45, 'kiwi': 2.7, 'pineapple': 5.5, 'grapes': 3.85}
fruitsWeekend = {'banana': 2.70, 'apple': 1.25, 'orange': 0.90, 'grapefruit': 1.60, 'kiwi': 3, 'pineapple': 5.6, 'grapes': 4.2}

if day in weekends:
    if fruit in fruits:
        totalPrice = qty * fruitsWeekend[fruit]
        print(f"{totalPrice:.2f}")
    else:
        print('error')
elif day in weekdays:
    if fruit in fruits:
        totalPrice = qty * fruitsWeekday[fruit]
        print(f"{totalPrice:.2f}")
    else:
        print("error")
else:
    print("error")
