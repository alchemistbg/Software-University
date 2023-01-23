# 100/100

times = [int(s) for s in input().split()]

middle_idx = len(times) // 2

left_racer_times = times[0:middle_idx]
right_racer_times = times[-1:middle_idx:-1]

left_racer_total_time = 0.0
right_racer_total_time = 0.0

for idx in range(middle_idx):
    left_racer_total_time += left_racer_times[idx]
    if left_racer_times[idx] == 0:
        left_racer_total_time *= 0.8

    right_racer_total_time += right_racer_times[idx]
    if right_racer_times[idx] == 0:
        right_racer_total_time *= 0.8

if left_racer_total_time < right_racer_total_time:
    print(f'The winner is left with total time: {left_racer_total_time:.1f}')
else:
    print(f'The winner is right with total time: {right_racer_total_time:.1f}')

