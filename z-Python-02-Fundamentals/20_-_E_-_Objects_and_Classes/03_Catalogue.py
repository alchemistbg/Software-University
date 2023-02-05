# 100/100

class Product:

    def __init__(self, product_name):
        self.product_name = product_name


class Catalogue:

    def __init__(self, name):
        self.name = name
        self.products = []

    def add_product(self, product_name):
        product = Product(product_name)
        self.products.append(product)

    def get_by_letter(self, first_letter):
        result = [product.product_name for product in self.products if product.product_name[0] == first_letter]
        return result

    def __repr__(self):
        current_products = [product.product_name for product in self.products]
        current_products = sorted(current_products, key = None)
        return f'Items in the {self.name} catalogue:\n' + '\n'.join(current_products)


catalogue = Catalogue("Furniture")
catalogue.add_product("Sofa")
catalogue.add_product("Mirror")
catalogue.add_product("Desk")
catalogue.add_product("Chair")
catalogue.add_product("Carpet")
print(catalogue.get_by_letter("C"))
print(catalogue)

