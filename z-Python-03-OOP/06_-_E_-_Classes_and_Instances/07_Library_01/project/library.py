from typing import List, Union
# from .user import User


class Library:

    def __init__(self):
        self.user_records = []
        self.books_available = {}
        self.rented_books = {}

    def __have_user_id(self, user_id: int) -> bool:
        user_ids = [u.user_id for u in self.user_records]
        return user_id in user_ids

    # def __get_user_by_id(self, user_id: int) -> User:
    def __get_user_by_id(self, user_id: int):
        return [user for user in self.user_records if user.user_id == user_id][0]

    # def add_user(self, user: User) -> Union[None, str]:
    def add_user(self, user) -> Union[None, str]:
        if self.__have_user_id(user.user_id):
            return f"User with id = {user.user_id} already registered in the library!"

        self.user_records.append(user)

    # def remove_user(self, user: User) -> Union[None, str]:
    def remove_user(self, user) -> Union[None, str]:
        if not self.__have_user_id(user.user_id):
            return "We could not find such user to remove!"

        # The following rows perform some additional operations in order to keep data consistent
        # If the user has rented some books, his record is moved from rented_books and are moved into available_books
        # if user.username in self.rented_books.keys():
        #     deleted_user_books = self.rented_books.pop(user.username)
        #     self.books_available.update(deleted_user_books)
        # The above code doesn't work good. In rented_books there is no info about the author.
        # That's why books can't be moved into available_books

        self.user_records.remove(user)

    def change_username(self, user_id: int, new_username: str):
        if not self.__have_user_id(user_id):
            return f"There is no user with id = {user_id}!"

        user = self.__get_user_by_id(user_id)
        if user.username == new_username:
            return "Please check again the provided username - it should be different than the username used so far!"

        # This is done in order to be consistent with the deletion of the user from the library records
        # self.rented_books[new_username] = self.rented_books.pop(user.username)
        user.username = new_username
        return f"Username successfully changed to: {new_username} for userid: {user_id}"