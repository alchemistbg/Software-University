# 100/100
# https://judge.softuni.org/Contests/Practice/Index/3744#0
from collections import deque

peaks = {
    'Vihren': 80,
    'Kutelo': 90,
    'Banski Suhodol': 100,
    'Polezhan':	60,
    'Kamenitza': 70
}

all_peaks = list(peaks.keys())
conquered_peaks = []

portions = deque(map(int, input().split(', ')))
staminas = deque(map(int, input().split(', ')))

current_peak_idx = 0
while True:
    if not portions or not staminas or current_peak_idx == 5:
        break

    portion = portions.pop()
    stamina = staminas.popleft()
    current_day_power = portion + stamina

    current_peak_name = all_peaks[current_peak_idx]
    current_peak_difficulty = peaks[current_peak_name]

    if current_day_power >= current_peak_difficulty:
        conquered_peaks.append(current_peak_name)
        current_peak_idx += 1

if current_peak_idx == 5:
    print('Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK')
else:
    print('Alex failed! He has to organize his journey better next time -> @PIRINWINS')

if conquered_peaks:
    print('Conquered peaks:')
    print('\n'.join(conquered_peaks))
