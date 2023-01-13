# 100/100

text = input()
totalSteps = 0

while text != "Going home":
    steps = int(text)
    totalSteps += steps

    if totalSteps >= 10000:
        break

    text = input()

if text == "Going home":
    text = int(input())
    totalSteps += text

if totalSteps >= 10000:
    print("Goal reached! Good job!")
    print(f"{totalSteps - 10000} steps over the goal!")
else:
    print(f"{10000 - totalSteps} more steps to reach goal.")
