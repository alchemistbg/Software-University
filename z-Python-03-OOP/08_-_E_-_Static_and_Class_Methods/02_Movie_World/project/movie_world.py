from typing import List
from .customer import Customer
from .dvd import DVD


class MovieWorld:

    def __init__(self, name: str):
        self.name = name
        self.customers: List[Customer] = []
        self.dvds: List[DVD] = []

    @staticmethod
    def dvd_capacity():
        return 15

    @staticmethod
    def customer_capacity():
        return 10

    def _find_dvd_by_id(self, dvd_id):
        dvd = [dvd for dvd in self.dvds if dvd.id == dvd_id]
        if dvd:
            return dvd[0]

    def _find_customer_by_id(self, customer_id):
        customer = [customer for customer in self.customers if customer.id == customer_id]
        if customer:
            return customer[0]

    def _find_rented_dvd_by_id(self, customer, dvd_id):
        rented_dvd = [dvd for dvd in customer.rented_dvds if dvd.id == dvd_id]
        if rented_dvd:
            return rented_dvd[0]

    def add_customer(self, customer: Customer):
        if len(self.customers) < self.customer_capacity():
            self.customers.append(customer)
            # Lecturer's idea:
            # Could create instance collection (dict or list) that holds customers' ids that
            # could be used instead of _find_customer_by_id method

    def add_dvd(self, dvd: DVD):
        if len(self.dvds) < self.dvd_capacity():
            self.dvds.append(dvd)
            # Lecturer's idea:
            # Could create instance collection (dict or list) that holds dvds' ids that
            # could be used instead of _find_dvd_by_id method

    def rent_dvd(self, customer_id: int, dvd_id: int) -> str:
        customer = self._find_customer_by_id(customer_id)
        dvd = self._find_dvd_by_id(dvd_id)

        # Unsuccessful operations
        # 1. If the customer has already rented that dvd
        rented_dvd = self._find_rented_dvd_by_id(customer, dvd_id)
        if rented_dvd:
            return f"{customer.name} has already rented {dvd.name}"

        # 2. If the dvd is rented by someone else:
        if dvd.is_rented:
            return "DVD is already rented"

        # 3. If the customer is not allowed to rent the DVD:
        if customer.age < dvd.age_restriction:
            return f"{customer.name} should be at least {dvd.age_restriction} to rent this movie"

        dvd.is_rented = True
        customer.rented_dvds.append(dvd)
        return f"{customer.name} has successfully rented {dvd.name}"

    def return_dvd(self, customer_id: int, dvd_id: int) -> str:
        customer = self._find_customer_by_id(customer_id)
        rented_dvd = self._find_rented_dvd_by_id(customer, dvd_id)
        if rented_dvd is None:
            return f"{customer.name} does not have that DVD"

        self.dvds.remove(rented_dvd)
        customer.rented_dvds.remove(rented_dvd)
        rented_dvd.is_rented = False
        return f"{customer.name} has successfully returned {rented_dvd.name}"

    def __repr__(self):
        representation = []
        for customer in self.customers:
            representation.append(f"{customer}")

        for dvd in self.dvds:
            representation.append(f"{dvd}")

        return "\n".join(representation)
