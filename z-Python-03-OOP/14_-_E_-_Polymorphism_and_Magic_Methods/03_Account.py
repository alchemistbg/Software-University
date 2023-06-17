from typing import List


class Account:

	def __init__(self, owner: str, amount: int = 0):
		self.owner = owner
		self.amount = amount
		self._transactions: List[int] = []

	def add_transaction(self, amount: int):
		if not isinstance(amount, int):
			raise ValueError("please use int for amount")
		self._transactions.append(amount)
