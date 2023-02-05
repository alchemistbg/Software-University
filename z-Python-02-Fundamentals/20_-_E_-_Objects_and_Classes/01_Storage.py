# 100/100
# This code is working. Input validations are not necessary.

class Product:

    def __init__(self, product_name: str):
        self.product_name = product_name


class Storage:

    def __init__(self, capacity: int):
        self.storage = []
        self.capacity = 0
        if capacity >= 0 or type(capacity) == int:
            self.capacity = capacity

    def add_product(self, product_name: str):
        product = Product(product_name)
        current_fill = len(self.storage)
        if current_fill < self.capacity:
            self.storage.append(product)

    def get_products(self):
        return [product.product_name for product in self.storage]


storage = Storage(4)
storage.add_product("apple")
storage.add_product("banana")
storage.add_product("potato")
storage.add_product("tomato")
storage.add_product("bread")
print(storage.get_products())

