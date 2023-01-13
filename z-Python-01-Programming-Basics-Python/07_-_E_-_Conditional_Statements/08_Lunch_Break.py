# 100/100

import math

serial = input()
episodeTime = int(input())
breakTime = int(input())

lunchTime = breakTime / 8
restTime = breakTime / 4

freeTime = breakTime - lunchTime - restTime

timeDiff = 0
if freeTime >= episodeTime:
    timeDiff = math.ceil(freeTime - episodeTime)
#     print(timeDiff)
    print(f"You have enough time to watch {serial} and left with {timeDiff:.0f} minutes free time.")
else:
    timeDiff = math.ceil(episodeTime - freeTime)
#     print(timeDiff)
    print(f"You don't have enough time to watch {serial}, you need {timeDiff:.0f} more minutes.")
