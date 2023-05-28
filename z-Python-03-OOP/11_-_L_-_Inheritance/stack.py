from typing import List


class Stack:

    def __init__(self):
        self.data: List[str] = []

    def push(self, el):
        if isinstance(el, str):
            self.data.append(el)

    def pop(self) -> str:
        return self.data.pop()

    def top(self):
        return self.data[-1]

    def is_empty(self):
        return len(self.data) == 0

    def __str__(self):
        r_data = reversed(self.data)
        output = f"[{', '.join(r_data)}]"
        return output
