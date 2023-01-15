balls_count = int(input())

best_snowball_value = 0
result = ''

current_ball = 1
while current_ball <= balls_count:
    snowball_snow = int(input())
    snowball_time = int(input())
    snowball_quality = int(input())

    snowball_value = (snowball_snow // snowball_time)**snowball_quality
    if snowball_value > best_snowball_value:
        best_snowball_value = snowball_value
        result = f'{snowball_snow} : {snowball_time} = {snowball_value} ({snowball_quality})'

    current_ball += 1

print(result)
