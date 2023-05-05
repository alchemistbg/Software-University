# 100/100

from typing import Dict


class Store:
    def __init__(self, name: str, type: str, capacity: int):
        self.name = name
        self.type = type
        self.capacity = capacity
        self.items: Dict[str, int] = {}

    # @staticmethod
    # def from_size(name: str, type: str, size: int):
    #     return Store(name, type, size)

    @classmethod
    def from_size(cls, name: str, type: str, size: int):
        corrected_size = size // 2
        return cls(name, type, corrected_size)

    def add_item(self, item_name: str):
        if item_name not in self.items.keys():
            self.items[item_name] = 0

        total_items = sum(self.items.values())
        if total_items + 1 > self.capacity:
            return "Not enough capacity in the shop"

        self.items[item_name] += 1
        return f"{item_name} added to the shop"

    def remove_item(self, item_name: str, amount: int):
        if item_name not in self.items.keys() or self.items[item_name] < amount:
            return f"Cannot remove {amount} {item_name}"

        self.items[item_name] -= amount
        if self.items[item_name] == 0:
            del self.items[item_name]
        return f"{amount} {item_name} removed from the shop"

    def __repr__(self):
        return f"{self.name} of type {self.type} with capacity {self.capacity}"


first_store = Store("First store", "Fruit and Veg", 20)
second_store = Store.from_size("Second store", "Clothes", 500)

print(first_store)
print(second_store)

print(first_store.add_item("potato"))
print(second_store.add_item("jeans"))
print(first_store.remove_item("tomatoes", 1))
print(second_store.remove_item("jeans", 1))

