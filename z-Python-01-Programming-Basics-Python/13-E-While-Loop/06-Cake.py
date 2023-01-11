# 100/100

cakeWidth = int(input())
cakeLength = int(input())

cakeArea = cakeWidth * cakeLength

while cakeArea > 0:
    text = input()
    if text == "STOP":
        print(f"{cakeArea} pieces are left." )
        break
    pieces = int(text)
    cakeArea -= pieces
    if cakeArea <= 0:
        print(f"No more cake left! You need {abs(cakeArea)} pieces more.")
