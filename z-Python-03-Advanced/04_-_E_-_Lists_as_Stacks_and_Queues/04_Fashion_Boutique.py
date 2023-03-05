# 100/100

clothes = list(map(int, input().split()))

rack_capacity = int(input())
current_rack_capacity = rack_capacity
rack_count = 1

while len(clothes) > 0:
    cloth = clothes.pop()
    if current_rack_capacity >= cloth:
        current_rack_capacity -= cloth
    else:
        current_rack_capacity = rack_capacity
        current_rack_capacity -= cloth
        rack_count += 1

print(rack_count)
