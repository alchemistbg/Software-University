# 100/100

cheap = "Monday, Tuesday, Friday"
medium = "Wednesday, Thursday"
expensive = "Saturday, Sunday"

text = input()

if text in cheap:
    print(12)
elif text in medium:
    print(14)
elif text in expensive:
    print(16)
else:
    print("ERROR")
