# 100/100

contestant1 = int(input())
contestant2 = int(input())
contestant3 = int(input())

totalTime = contestant1 + contestant2 + contestant3

minutes = int(totalTime // 60)
seconds = totalTime % 60

# solution with string formating
# print(f"{minutes}:{seconds:02d}")

#solution with using if-else
if seconds < 10:
    print(f"{minutes}:0{seconds}")
else:
    print(f"{minutes}:{seconds}")
