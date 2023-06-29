from typing import List


class BookNotFoundException(Exception):
    pass


class Book:
    def __init__(self, title, author):
        self.title = title
        self.author = author
        self.page = 0

    def turn_page(self, page):
        self.page = page

    def __str__(self):
        return f"Book {self.title} by {self.author}"


class Library:

    def __init__(self, books: List[Book]):
        self.books = books

    def find_book(self, book_title):
        try:
            book_result = [b for b in self.books if b.title == book_title]
            if not book_result:
                raise BookNotFoundException
            return book_result[0]
        except BookNotFoundException:
            return f"Book {book_title} was not found!"


book1 = Book('Book1', 'author1')
book2 = Book('Book2', 'author2')
book3 = Book('Book3', 'author3')

library = Library([book1, book2, book3])

print(library.find_book('Book1'))
print(library.find_book('Book4'))
