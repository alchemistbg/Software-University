from typing import List
from .product import Product


class ProductRepository:

	def __init__(self):
		self.products: List[Product] = []

	def add(self, product: Product):
		self.products.append(product)

	def find(self, product_name: str):
		product = [product for product in self.products if product.name == product_name]
		if product:
			return product[0]

	def remove(self, product_name):
		product_to_remove = self.find(product_name)
		if product_to_remove in self.products:
			self.products.remove(product_to_remove)

	def __repr__(self):
		products_info = [f"{p.name}: {p.quantity}" for p in self.products]
		nl = "\n"
		return f"{nl.join(products_info)}"
