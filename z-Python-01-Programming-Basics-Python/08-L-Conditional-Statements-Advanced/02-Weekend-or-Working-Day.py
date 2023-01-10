

text = input()

weekDays = "Monday, Tuesday, Wednesday, Thursday, Friday"
weekendDays = "Saturday, Sunday"

if text in weekDays:
    print("Working day")
elif text in weekendDays:
    print("Weekend")
else:
    print("Error")
