# 100/100

age = int(input())
wmPrice = float(input())
toysPrice = int(input())

toysCount = 0

totalSavings = 0

for i in range(1, age + 1):
    if i % 2 == 0:
        totalSavings += (i // 2) * 10
        totalSavings -= 1
    else:
        toysCount += 1

toysSavings = toysPrice * toysCount
totalSavings += toysSavings

diff = totalSavings - wmPrice

if diff >= 0:
    print(f"Yes! {diff:.2f}")
else:
    print(f"No! {abs(diff):.2f}")
