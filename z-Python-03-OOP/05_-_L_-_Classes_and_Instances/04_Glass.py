

class Glass:
    capacity = 250

    def __init__(self):
        self.content = 0
        self.curr_capacity = Glass.capacity

    def fill(self, qty: int) -> str:
        if self.curr_capacity < qty:
            return f"Cannot add {qty} ml"

        self.curr_capacity -= qty
        self.content += qty
        return f"Glass filled with {qty} ml"

    def empty(self) -> 0:
        self.curr_capacity = Glass.capacity
        self.content = 0
        return "Glass is now empty"

    def info(self):
        return f"{self.curr_capacity} ml left"

glass = Glass()
print(glass.fill(100))
print(glass.fill(200))
print(glass.empty())
print(glass.fill(200))
print(glass.info())

glass2 = Glass()
print(glass2.fill(100))
print(glass2.fill(200))
print(glass2.empty())
print(glass2.fill(150))
print(glass2.info())
