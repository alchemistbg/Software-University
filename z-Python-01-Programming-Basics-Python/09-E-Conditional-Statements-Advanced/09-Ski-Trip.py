# 100/100

days = int(input())
premises = input()
grade = input()

room = 18.00
flat = 25.00
apartment = 35.00

roomPrice = (days - 1) * room
flatPrice = (days - 1) * flat
apartmentPrice = (days - 1) * apartment

roomDiscount = 0
flatDiscount = 0
apartmentDiscount = 0

if days < 10:
    roomDiscount = 0
    flatDiscount = flatPrice * 0.3
    apartmentDiscount = apartmentPrice * 0.1
elif days > 9 and days < 16:
    roomDiscount = 0
    flatDiscount = flatPrice * 0.35
    apartmentDiscount = apartmentPrice * 0.15
else:
    roomDiscount = 0
    flatDiscount = flatPrice * 0.5
    apartmentDiscount = apartmentPrice * 0.2

roomPrice -= roomDiscount
flatPrice -= flatDiscount
apartmentPrice -= apartmentDiscount

gradeDiscount = 0
if grade == "positive":
    gradeDiscount = 0.25
else:
    gradeDiscount = -0.1

if premises == "room for one person":
    print(f"{roomPrice + (roomPrice * gradeDiscount):.2f}")
elif premises == "apartment":
    print(f"{flatPrice + (flatPrice * gradeDiscount):.2f}")
else:
    print(f"{apartmentPrice + (apartmentPrice * gradeDiscount):.2f}")
