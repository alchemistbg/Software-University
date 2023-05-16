# 100/100
from typing import Union


class Account:

    def __init__(self, id: int, balance: float, pin: int):
        self.__id = id
        self.__pin = pin
        self.balance = balance

    def __is_pin_correct(self, pin: int) -> int:
        return self.__pin == pin

    def get_id(self, pin: int) -> Union[int, str]:
        if self.__is_pin_correct(pin):
            return self.__id
        return 'Wrong pin'

    def change_pin(self, old_pin: int, new_pin: int) -> str:
        if self.__is_pin_correct(old_pin):
            self.__pin = new_pin
            return "Pin changed"

        return "Wrong pin"


