# 100/100

import math

tasks = list(map(int, input().split(', ')))
job_idx = int(input())
job_value = tasks[job_idx]

total_cycles = 0

while True:
    min_job_value = min(tasks)
    min_job_idx = tasks.index(min_job_value)
    tasks[min_job_idx] = math.inf

    total_cycles += min_job_value

    if min_job_idx == job_idx and min_job_value == job_value:
        break

print(total_cycles)
