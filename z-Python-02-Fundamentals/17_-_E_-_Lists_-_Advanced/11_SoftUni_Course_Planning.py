# 100/100

schedule = input().split(', ')

while True:
    command = input()
    if command == 'course start':
        break

    tokens = command.split(':')
    action = tokens[0]
    title = tokens[1]

    if action == 'Add' and title not in schedule:
        schedule.append(title)

    elif action == 'Insert' and title not in schedule:
        idx = int(tokens[2])
        schedule.insert(idx, title)

    elif action == 'Remove' and title in schedule:
        schedule.remove(title)
        if title + '-Exercise' in schedule:
            schedule.remove(title + '-Exercise')

    elif action == 'Swap':
        title2 = tokens[2]
        if title in schedule and title2 in schedule:

            idx1 = schedule.index(title)
            idx2 = schedule.index(title2)
            schedule[idx1], schedule[idx2] = schedule[idx2], schedule[idx1]

            if title + '-Exercise' in schedule:
                idx1_exer = schedule.index(title + '-Exercise')
                schedule.insert(idx2 + 1, schedule[idx1_exer])
                schedule.pop(idx1_exer + 1)

            if title2 + '-Exercise' in schedule:
                idx2_exer = schedule.index(title2 + '-Exercise')
                schedule.insert(idx1 + 1, schedule[idx2_exer])
                schedule.pop(idx2_exer + 1)

    elif action == 'Exercise':
        if title in schedule and title + '-Exercise' not in schedule:
            idx = schedule.index(title)
            schedule.insert(idx + 1, title + '-Exercise')

        elif title not in schedule:
            schedule.append(title)
            schedule.append(title + '-Exercise')

result = '\n'.join([f'{i + 1}.{schedule[i]}' for i in range (len(schedule))])
print(result)