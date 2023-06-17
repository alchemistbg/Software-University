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

	@property
	def balance(self):
		return self.amount + sum(self._transactions)

	# This method is based on the old description of the problem
	@staticmethod
	def validate_transaction(account: 'Account', amount_to_add):
		if account.balance + amount_to_add < 0:
			raise ValueError("sorry cannot go in debt!")
		account.add_transaction(amount_to_add)
		return account.balance
