# 100/100

days = int(input())
hours = int(input())

total_park_bill = 0

for day in range(1, days + 1):
    day_park_bill = 0
    for hour in range(1, hours + 1):
        if day % 2 == 0 and hour % 2 != 0:
            day_park_bill += 2.5
        elif day % 2 != 0 and hour % 2 == 0:
            day_park_bill += 1.25
        else:
            day_park_bill += 1
    print(f'Day: {day} - {day_park_bill:.2f} leva')
    total_park_bill += day_park_bill

print(f'Total: {total_park_bill:.2f} leva')
