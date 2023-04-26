# 100/100


class Time:
    max_hours = 23
    max_minutes = 59
    max_seconds = 59

    def __init__(self, h, m, s):
        self.hours = h
        self.minutes = m
        self.seconds = s

    def set_time(self, new_h, new_m, new_s):
        self.hours = new_h
        self.minutes = new_m
        self.seconds = new_s

    def get_time(self):
        return f"{self.hours:02d}:{self.minutes:02d}:{self.seconds:02d}"

    def next_second(self):
        if self.seconds + 1 > Time.max_seconds:
            self.seconds = 0
            if self.minutes + 1 > Time.max_minutes:
                self.minutes = 0
                if self.hours + 1 > self.max_hours:
                    self.hours = 0
                else:
                    self.hours += 1
            else:
                self.minutes += 1
        else:
            self.seconds += 1

        return self.get_time()


time1 = Time(9, 30, 58)
print(time1.next_second())
time2 = Time(10, 59, 59)
print(time2.next_second())
time3 = Time(23, 59, 59)
print(time3.next_second())
