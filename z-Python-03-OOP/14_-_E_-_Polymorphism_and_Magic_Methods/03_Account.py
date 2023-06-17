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

	def __str__(self):
		return f"Account of {self.owner} with starting amount: {self.amount}"

	def __repr__(self):
		return f"Account({self.owner}, {self.amount})"

	def __len__(self):
		return len(self._transactions)

	def __getitem__(self, key):
		return self._transactions[key]

	def __eq__(self, other: 'Account'):
		return self.balance == other.balance

	def __ne__(self, other: 'Account'):
		return self.balance != other.balance

	def __gt__(self, other: 'Account'):
		return self.balance > other.balance

	def __ge__(self, other: 'Account'):
		return self.balance >= other.balance

	def __lt__(self, other: 'Account'):
		return self.balance < other.balance

	def __le__(self, other: 'Account'):
		return self.balance <= other.balance

	def __add__(self, other: 'Account'):
		new_name = f'{self.owner}&{other.owner}'
		new_transactions = self._transactions + other._transactions
		account = Account(new_name, 10)
		account._transactions = new_transactions[:]
		return account
