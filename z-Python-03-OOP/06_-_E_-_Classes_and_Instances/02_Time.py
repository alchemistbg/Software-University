# 100/100
from typing import ClassVar


class Time:
    max_hours: ClassVar[int] = 23
    max_minutes: ClassVar[int] = 59
    max_seconds: ClassVar[int] = 59

    def __init__(self, h, m, s):
        self.hours = h
        self.minutes = m
        self.seconds = s

    def set_time(self, new_h, new_m, new_s) -> None:
        self.hours = new_h
        self.minutes = new_m
        self.seconds = new_s

    def get_time(self) -> str:
        return f"{self.hours:02d}:{self.minutes:02d}:{self.seconds:02d}"

    def next_second(self) -> str:
        # Reimplement this method using lecturer's logic
        self.seconds = (self.seconds + 1) % (Time.max_seconds + 1)
        self.minutes = (self.minutes + (self.seconds == 0)) % (Time.max_minutes + 1)
        self.hours = (self.hours + (self.minutes == 0 and self.seconds == 0)) % (Time.max_hours + 1)

        return self.get_time()


time1 = Time(9, 30, 59)
print(time1.next_second())
time2 = Time(10, 59, 59)
print(time2.next_second())
time3 = Time(23, 59, 59)
print(time3.next_second())
time4 = Time(0, 0, 0)
print(time3.next_second())
