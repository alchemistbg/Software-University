# 100/100

import math

examHour = int(input())
examMinutes = int(input())
arrivalHour = int(input())
arrivalMinutes = int(input())

totalExamMinutes = examHour * 60 + examMinutes
totalArrivalTime = arrivalHour * 60 + arrivalMinutes

diff = totalExamMinutes - totalArrivalTime

if diff > 30:
    print("Early")
elif diff >= 0 and diff <= 30:
    print("On time")
else:
    print("Late")

diffHour = abs(diff) // 60
diffMin = abs(diff) % 60

if diff >= 60:
    print(f"{diffHour}:{diffMin:02d} hours before the start")
elif diff >= 0 and diff < 60:
    print(f"{diffMin} minutes before the start")
elif diff < 0 and diff > -60:
    print(f"{diffMin} minutes after the start")
else:
    print(f"{diffHour}:{diffMin:02d} hours after the start")
