from abc import ABC, abstractmethod


class Book:

    def __init__(self, title, author, content):
        self.title = title
        self.author = author
        self.content = content


class Formatter(ABC):

    @abstractmethod
    def format(self, book: Book):
        pass


class ContentFormatter(Formatter):

    def format(self, book: Book):
        return book.content


class CoverFormatter(Formatter):

    def format(self, book: Book):
        return f'{book.title}\nby\n{book.author}'


class Printer:

    def print(self, book: Book, formatter: Formatter):
        return formatter.format(book)


book = Book('Nice book', 'Nice Author', 'A very nice content')
printer = Printer()
print(printer.print(book, CoverFormatter()))
print(printer.print(book, ContentFormatter()))
