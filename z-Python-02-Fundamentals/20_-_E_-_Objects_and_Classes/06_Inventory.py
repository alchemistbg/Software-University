# 100/100

class Inventory:
    def __init__(self, capacity: int):
        self.__capacity = capacity
        self.items = []

    def __get_items_count(self):
        return len(self.items)

    def get_capacity(self):
        return self.__capacity

    def add_item(self, item: str):
        current_items_count = self.__get_items_count()
        if current_items_count < self.__capacity:
            self.items.append(item)
        else:
            return 'not enough room in the inventory'

    def __repr__(self):
        current_items = ', '.join(self.items)
        current_free_space = self.__capacity - self.__get_items_count()
        return f'Items: {current_items}.\nCapacity left: {current_free_space}'


# 80/100
# class Item:
#     def __init__(self, item_name):
#         self.item_name = item_name
#
#
# class Inventory:
#     def __init__(self, capacity: int):
#         self.__capacity = capacity
#         self.items = []
#
#     def __get_items_count(self):
#         return len(self.items)
#
#     def __get_items_names(self):
#         return [item.item_name for item in self.items]
#
#     def get_capacity(self):
#         return self.__capacity
#
#     def add_item(self, new_item: str):
#         current_items_count = self.__get_items_count()
#         if current_items_count < self.__capacity:
#             item = Item(new_item)
#             self.items.append(item)
#         else:
#             return 'not enough room in the inventory'
#
#     def __repr__(self):
#         current_items = ', '.join(self.__get_items_names())
#         current_free_space = self.__capacity - self.__get_items_count()
#         return f'Items: {current_items}.\nCapacity left: {current_free_space}'


inventory = Inventory(2)
inventory.add_item("potion")
inventory.add_item("sword")
print(inventory.add_item("bottle"))
print(inventory.get_capacity())
print(inventory)
