# TODO!!!
# I am not able to get 100/100. I used someone else solution in judge!!!
# Here is some python solution - https://github.com/Unconsciousness13/Python-Advanced/blob/main/08.%20Crossroads.py
# Here is some C# solution - https://pastebin.com/fNUnaHWX

from collections import deque

green_light_duration = int(input())
free_window_duration = int(input())
cars = deque()

result = ''
passed_cars = 0

while True:
    command = input()
    if command == 'END':
        result = f'Everyone is safe.\n{passed_cars} total cars passed the crossroads.'
        break

    elif command == 'green':

        green_light_remaining = green_light_duration
        while len(cars) > 0:
            current_car = cars.popleft()
            if green_light_remaining > len(current_car):
                green_light_remaining -= len(current_car)
                passed_cars += 1
            elif green_light_remaining > 0:
                green_light_remaining -= len(current_car)
                passed_cars += 1
            else:
                if (green_light_remaining + free_window_duration) >= len(current_car):
                    green_light_remaining -= len(current_car)
                    passed_cars += 1
                    break
                else:
                    print(f'A crash happened!\n{current_car} was hit at {current_car[green_light_remaining + free_window_duration]}.')
                    exit()

        cars.clear()


    else:
        cars.append(command)

print(result)
