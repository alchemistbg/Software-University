# 100/100

rooms = int(input())

free_chairs = 0
missing_chairs = []

counter = 0
while counter < rooms:
    room = input().split()
    chairs = int(room[0].count('X'))
    visitors = int(room[1])

    diff = visitors - chairs
    if diff > 0:
        missing_chairs.append(f'{diff} more chairs needed in room {counter + 1}')
        # This could be printed here. Could be used some flag that shows shortage of chairs

    if diff < 0:
        free_chairs += diff * -1

    counter += 1

# Here could be printed only the case with excess based on a flag
if len(missing_chairs) > 0:
    print('\n'.join(missing_chairs))
else:
    print(f'Game On, {free_chairs} free chairs left')
