# 100/100

degrees = int(input())
time = input()

outfit = ""
shoes = ""
if time == "Morning":
    if degrees >= 10 and degrees <= 18:
        outfit = "Sweatshirt"
        shoes = "Sneakers"
    elif degrees > 18 and degrees <= 24:
        outfit = "Shirt"
        shoes = "Moccasins"
    else:
        outfit = "T-Shirt"
        shoes = "Sandals"
elif time == "Afternoon":
    if degrees >= 10 and degrees <= 18:
        outfit = "Shirt"
        shoes = "Moccasins"
    elif degrees > 18 and degrees <= 24:
        outfit = "T-Shirt"
        shoes = "Sandals"
    else:
        outfit = "Swim Suit"
        shoes = "Barefoot"
else:
    if degrees >= 10 and degrees <= 18:
        outfit = "Shirt"
        shoes = "Moccasins"
    elif degrees > 18 and degrees <= 24:
        outfit = "Shirt"
        shoes = "Moccasins"
    else:
        outfit = "Shirt"
        shoes = "Moccasins"

print(f"It's {degrees} degrees, get your {outfit} and {shoes}.")
