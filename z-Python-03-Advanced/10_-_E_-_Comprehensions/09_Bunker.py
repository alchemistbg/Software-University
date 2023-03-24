# I cannot test this solution, because the problem is removed from the judge system

bunker = {category:[] for category in input().split(', ')}

total_inputs = int(input())

for _ in range(total_inputs):
    food_type, food_name, food_data = input().split(' - ')
    quantity, quality = food_data.split(';')
    quantity_value = int(quantity.split(':')[1])
    quality_value = int(quality.split(':')[1])

    bunker[food_type].append((food_name, quantity_value, quality_value))

total_items_count = sum([data[1] for key,value in bunker.items() for data in value])
total_items_quality = sum([data[2] for key,value in bunker.items() for data in value])
categories_count = len(bunker.keys())

average_quality = total_items_quality / categories_count

print(f'Count of items: {total_items_count}')
print(f'Average quality: {average_quality:.2f}')
[print(f'{cat} -> {", ".join([food[0] for food in foods])}') for cat, foods in bunker.items()]
