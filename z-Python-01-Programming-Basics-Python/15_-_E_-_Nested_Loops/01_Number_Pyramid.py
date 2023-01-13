# 100/100

number = int(input())
counter = 1
toBreak = False

for row in range(1, number + 1):
    for col in range(1, row + 1):
        if counter > number:
            toBreak = True
            break

        print(f"{counter}", end=" ")
        counter += 1

    if toBreak:
        break

    print()
