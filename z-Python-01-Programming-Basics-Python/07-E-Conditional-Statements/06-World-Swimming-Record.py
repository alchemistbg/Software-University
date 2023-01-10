# 100/100

currentRecord = float(input())
distance = float(input())
speed = float(input())

ivanTime = distance * speed

waterResistance = distance // 15 * 12.5

ivanTime += waterResistance

if ivanTime < currentRecord:
    print(f" Yes, he succeeded! The new world record is {ivanTime:.2f} seconds.")
else:
    timeDifference = ivanTime - currentRecord
    print(f"No, he failed! He was {timeDifference:.2f} seconds slower.")
