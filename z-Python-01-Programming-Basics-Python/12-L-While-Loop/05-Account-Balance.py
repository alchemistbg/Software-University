# 100/100

text = input()

accountSum = 0
while text != "NoMoreMoney":
    if float(text) < 0:
        print("Invalid operation!")
        break

    accountSum += float(text)
    print(f"Increase: {float(text):.2f}")

    text = input()

print(f"Total: {accountSum:.2f}")
