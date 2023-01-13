# 100/100

flatWidth = int(input())
flatLength = int(input())
flatHeigth = int(input())

flatFreeVolume = flatWidth * flatLength * flatHeigth

while flatFreeVolume > 0:
    text = input()

    if text == "Done":
        print(f"{flatFreeVolume} Cubic meters left.")
        break

    boxesVolume = int(text)
    flatFreeVolume -= boxesVolume

    if flatFreeVolume <= 0:
        print(f"No more free space! You need {abs(flatFreeVolume)} Cubic meters more.")
        break
