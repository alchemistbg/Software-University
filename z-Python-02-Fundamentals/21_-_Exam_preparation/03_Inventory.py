# 100/100

items = input().split(', ')

while True:
    command = input()
    if command == 'Craft!':
        break

    if 'Collect' in command:
        item = command.split(' - ')[1]
        if item not in items:
            items.append(item)

    if 'Drop' in command:
        item = command.split(' - ')[1]
        if item in items:
            items.remove(item)

    if 'Combine Items' in command:
        current_items = command.split(' - ')[1]
        old_item, new_item = current_items.split(':')

        if old_item in items:
            old_item_idx = items.index(old_item)
            items.insert(old_item_idx + 1, new_item)

    if 'Renew' in command:
        item = command.split(' - ')[1]
        if item in items:
            items.remove(item)
            items.append(item)

print(', '.join(items))