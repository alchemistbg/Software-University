# 100/100`

text = input()

sumOfVowels = 0
for ch in text:
    if ch == "a":
        sumOfVowels += 1
    elif ch == "e":
        sumOfVowels += 2
    elif ch == "i":
        sumOfVowels += 3
    elif ch == "o":
        sumOfVowels += 4
    elif ch == "u":
        sumOfVowels += 5

print(sumOfVowels)
