# 100/100

hours = int(input())
minutes = int(input())

if minutes >= 45:
    hours += 1
    minutes = (minutes + 15) - 60
else:
    minutes += 15

if hours >= 24:
    hours -= 24

print(f"{hours}:{minutes:02d}")
