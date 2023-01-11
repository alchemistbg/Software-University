# 100/100

budget = float(input())
season = input()

holidayType = ""
holidayPrice = 0
destination = ""

if budget <= 100:
    destination = "Bulgaria"
    if season == "summer":
        holidayPrice = budget * 0.3
        holidayType = "Camp"
    elif season == "winter":
        holidayPrice = budget * 0.7
        holidayType = "Hotel"
elif budget > 100 and budget <= 1000:
    destination = "Balkans"
    if season == "summer":
        holidayPrice = budget * 0.4
        holidayType = "Camp"
    elif season == "winter":
        holidayPrice = budget * 0.8
        holidayType = "Hotel"
else:
    destination = "Europe"
    holidayPrice = budget * 0.9
    holidayType = "Hotel"

print(f"Somewhere in {destination}\n{holidayType} - {holidayPrice:.2f}")
