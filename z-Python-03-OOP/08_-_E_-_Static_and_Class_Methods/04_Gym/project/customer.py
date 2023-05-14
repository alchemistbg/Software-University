# from itertools import count


class Customer:
    # id = count(start = 1)
    # The lecturer uses different approach for class id for this and for other classes
    # This could be used in all classes
    _id = 1

    def __init__(self, name: str, address: str, email: str):
        self.name = name
        self.address = address
        self.email = email
        # self.id = Customer.get_next_id()
        # Part of lecturer's approach
        self.id = self._id
        self.__class__._id += 1

    # @staticmethod
    # def get_next_id():
    #     return next(Customer.id)

    # Part of lecturer's approach
    @classmethod
    def get_next_id(cls):
        return cls._id

    def __repr__(self):
        return f"Customer <{self.id}> {self.name}; Address: {self.address}; Email: {self.email}"
