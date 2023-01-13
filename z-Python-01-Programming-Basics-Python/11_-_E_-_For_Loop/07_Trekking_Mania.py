# 100/100

groupsCount = int(input())

m1 = 0
m2 = 0
m3 = 0
m4 = 0
m5 = 0
totalPeopleCount = 0

for i in range(0, groupsCount):
    groupSize = int(input())
    totalPeopleCount += groupSize

    if groupSize <=5:
        m1 += groupSize
    elif groupSize >= 6 and groupSize <= 12:
        m2 += groupSize
    elif groupSize >= 13 and groupSize <= 25:
        m3 += groupSize
    elif groupSize >= 26 and groupSize <= 40:
        m4 += groupSize
    elif groupSize >= 41:
        m5 += groupSize

print(f"{(m1 / totalPeopleCount * 100):.2f}%")
print(f"{(m2 / totalPeopleCount * 100):.2f}%")
print(f"{(m3 / totalPeopleCount * 100):.2f}%")
print(f"{(m4 / totalPeopleCount * 100):.2f}%")
print(f"{(m5 / totalPeopleCount * 100):.2f}%")
