# from .library import Library


class User:

    def __init__(self, user_id: int, username: str):
        self.user_id = user_id
        self.username = username
        self.books = []

    # def __get_rented_books(self, library: Library):
    def __get_rented_books(self, library):
        rented_books = {}
        for books in library.rented_books.values():
            for book in books:
                rented_books[book] = books[book]
        return rented_books

    # def get_book(self, author: str, book_name: str, days_to_return: int, library: Library):
    def get_book(self, author: str, book_name: str, days_to_return: int, library):

        if book_name not in library.books_available[author]:
            rented_books = self.__get_rented_books(library)
            rented_days = rented_books[book_name]
            return f"The book '{book_name}' is already rented and will be available in " \
                   f"{rented_days} days!"

        self.books.append(book_name)
        library.books_available[author].remove(book_name)

        if self.username not in library.rented_books.keys():
            library.rented_books[self.username] = {}
        library.rented_books[self.username][book_name] = days_to_return

    # def return_book(self, author:str, book_name:str, library: Library):
    def return_book(self, author: str, book_name: str, library):
        if book_name not in self.books:
            return f"{self.username} doesn't have this book in his/her records!"

        self.books.remove(book_name)
        library.books_available[author].append(book_name)
        del library.rented_books[self.username][book_name]

    def info(self):
        return ', '.join(self.books)

    def __str__(self):
        return f"{self.user_id}, {self.username}, {self.books}"
