from typing import Dict
from .user import User
from itertools import chain


class Library:

    def __init__(self):
        self.user_records = []
        self.books_available = {}
        self.rented_books = {}

    def __get_rented_books(self):
        books = {}
        # TODO: rewrite it as dictionary comprehension
        for user_books in self.rented_books.values():
            for book, days in user_books.items():
                books[book] = days
        return books

    def get_book(self, author: str, book_name: str, days_to_return: int, user: User) -> str:

        if book_name not in self.books_available[author]:
            rented_books = self.__get_rented_books()
            rented_days = rented_books[book_name]

            return f'The book "{book_name}" is already rented and will be available in {rented_days} days!'

        user.books.append(book_name)
        self.books_available[author].remove(book_name)

        if user.username not in self.rented_books.keys():
            self.rented_books[user.username] = {}

        self.rented_books[user.username][book_name] = days_to_return
        return f"{book_name} successfully rented for the next {days_to_return} days!"

    def return_book(self, author: str, book_name: str, user: User):
        if book_name not in self.rented_books[user.username].keys():
            return f"{user.username} doesn't have this book in his/her records!"

        user.books.remove(book_name)
        del self.rented_books[user.username][book_name]
        self.books_available[author].append(book_name)

