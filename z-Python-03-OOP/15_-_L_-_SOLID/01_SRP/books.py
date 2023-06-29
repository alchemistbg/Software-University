from typing import List

class Book:
    def __init__(self, title, author):
        self.title = title
        self.author = author
        self.page = 0

    def turn_page(self, page):
        self.page = page

    def __str__(self):
        return f"Book {self.name} by {self.author}"


class Library:

    def __init__(self, books: List[Book]):
        self.books = books

    def find_book(self, book_title):
        for book in self.books:
            if book.title == book_title:
                return book 
