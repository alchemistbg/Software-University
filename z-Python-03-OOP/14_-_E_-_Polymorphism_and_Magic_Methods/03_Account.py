from typing import List


class Account:

	def __init__(self, owner: str, amount: int):
		self.owner = owner
		self.amount = amount
		self._transactions: List[int] = []
