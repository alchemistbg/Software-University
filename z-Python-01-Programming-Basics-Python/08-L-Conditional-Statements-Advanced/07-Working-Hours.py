# 100/100

hour = int(input())
day = input()

if day == "Sunday":
    print("closed")
else:
    if hour >= 10 and hour <=18:
        print("open")
    else:
        print("closed")
