# 100/100
from typing import Union
# This is imported in order to return different types of variables from one method

class Account:

    def __init__(self, account_id: str, name: str, balance: int = 0):
        self.id = account_id
        self.name = name
        self.balance = balance

    def credit(self, amount: int) -> int:
        self.balance += amount
        return self.balance

    def debit(self, amount: int) -> Union[int, str]:
        if amount > self.balance:
            return "Amount exceeded balance"

        self.balance -= amount
        return self.balance

    def info(self):
        return f"User {self.name} with account {self.id} has {self.balance} balance"


account_1 = Account(1234, "George", 1000)
print(account_1.credit(500))
print(account_1.debit(1500))
print(account_1.info())

print(72*'-')

account_2 = Account(5411256, "Peter")
print(account_2.debit(500))
print(account_2.credit(1000))
print(account_2.debit(500))
print(account_2.info())
