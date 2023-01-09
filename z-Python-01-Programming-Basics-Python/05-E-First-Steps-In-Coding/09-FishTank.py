# 100/100

length = int(input()) / 10
width = int(input()) / 10
height = int(input()) / 10
percentage = float(input()) / 100

fishTankVolume = length * width * height
waterVolume = fishTankVolume - (fishTankVolume * percentage)
print(waterVolume)
