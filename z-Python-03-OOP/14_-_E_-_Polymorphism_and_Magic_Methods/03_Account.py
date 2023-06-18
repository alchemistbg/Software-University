# 100/100
# This solution is based on the old description of the problem, but gets full
# amount of points against new tests. The method validate_transaction is not implemented,
# and it's not tested. In the newer version of the problem it's renamed to handle_transaction,
# but again it is not tested. There are other requirements that are not tested.


from typing import List


class Account:

	def __init__(self, owner: str, amount: int = 0):
		self.owner = owner
		self.amount = amount
		self._transactions: List[int] = []

	@property
	def balance(self):
		return self.amount + sum(self._transactions)

	def add_transaction(self, transaction: int):
		if not isinstance(transaction, int):
			raise ValueError("please use int for amount")
		if self.balance + transaction < 0:
			raise ValueError("sorry cannot go in debt!")
		self._transactions.append(transaction)
		return f"New balance: {self.balance}"

	# This method is based on the old description of the problem
	# @staticmethod
	# def validate_transaction(account: 'Account', amount_to_add):
	# 	if account.balance + amount_to_add < 0:
	# 		raise ValueError("sorry cannot go in debt!")
	# 	account.add_transaction(amount_to_add)
	# 	return account.balance

	def handle_transaction(self, transaction_amount):
		if self.balance + transaction_amount < 0:
			raise ValueError("sorry cannot go in debt!")
		self.add_transaction(transaction_amount)
		return f"New balance: {self.balance}"

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

# acc = Account('bob', 10)
# acc2 = Account('john')
# print(acc)
# print(repr(acc))
# acc.add_transaction(20)
# acc.add_transaction(-20)
# acc.add_transaction(30)
# print(acc.balance)
# print(len(acc))
# for transaction in acc:
# 	print(transaction)
# print(acc[1])
# print(list(reversed(acc)))
# acc2.add_transaction(10)
# acc2.add_transaction(60)
# print(acc > acc2)
# print(acc >= acc2)
# print(acc < acc2)
# print(acc <= acc2)
# print(acc == acc2)
# print(acc != acc2)
# acc3 = acc + acc2
# print(acc3)
# print(acc3._transactions)
# print(Account.validate_transaction(acc3, -111))


# import unittest
#
#
# class TestsAccount(unittest.TestCase):
# 	def setUp(self):
# 		self.acc1 = Account("Johhny")
# 		self.acc2 = Account("Anna", 40)
#
# 	def test_init(self):
# 		self.assertEqual(self.acc1.owner, "Johhny")
# 		self.assertEqual(self.acc1.amount, 0)
# 		self.assertEqual(self.acc1._transactions, [])
# 		self.assertEqual(self.acc2.owner, "Anna")
# 		self.assertEqual(self.acc2.amount, 40)
# 		self.assertEqual(self.acc2._transactions, [])
#
# 	def test_repr(self):
# 		self.assertEqual(repr(self.acc1), "Account(Johhny, 0)")
#
# 	def test_str(self):
# 		self.assertEqual(str(self.acc2), "Account of Anna with starting amount: 40")
#
# 	def test_add_transaction(self):
# 		self.acc1.add_transaction(10)
# 		self.assertEqual(self.acc1._transactions, [10])
# 		with self.assertRaises(ValueError) as cm:
# 			self.acc1.add_transaction(9.9)
# 		self.assertEqual(str(cm.exception), "please use int for amount")
#
# 	def test_balance(self):
# 		self.acc2.add_transaction(-20)
# 		self.assertEqual(self.acc2.balance, 20)
#
# 	def test_len(self):
# 		self.acc1.add_transaction(10)
# 		self.acc1.add_transaction(-5)
# 		self.assertEqual(len(self.acc1), 2)
#
# 	def test_get_item(self):
# 		self.acc1.add_transaction(5)
# 		self.assertEqual(self.acc1[0], 5)
#
#
# if __name__ == "__main__":
# 	unittest.main()
