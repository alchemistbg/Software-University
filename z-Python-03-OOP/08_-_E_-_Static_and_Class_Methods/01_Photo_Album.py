# 100/100

import math


class PhotoAlbum:

    def __init__(self, pages: int):
        self.pages = pages
        self.photos = [[] for _ in range(pages)]
        self.curr_page = 0
        self.curr_slot = 0

    @classmethod
    def from_photos_count(cls, photos_count: int) -> 'PhotoAlbum':
        pages = math.ceil(photos_count / 4)
        return cls(pages)

    def add_photo(self, label: str):
        # Lector's implementation:
        for idx, page in enumerate(self.photos):
            if len(page) < 4:
                page.append(label)
                return f"{label} photo added successfully on page {self.curr_page + 1} slot {self.curr_slot}"

        return f"No more free slots"

        # This is my implementation of the method - It also gets 100/100
        # if self.curr_page == self.pages - 1 and self.curr_slot == 4:
        #     return f"No more free slots"
        #
        # if self.curr_slot == 4:
        #     self.curr_slot = 0
        #     self.curr_page += 1
        # self.photos[self.curr_page].append(label)
        # self.curr_slot += 1
        #
        # return f"{label} photo added successfully on page {self.curr_page + 1} slot {self.curr_slot}"

    def display(self):
        album = []
        for page in self.photos:
            album.append("-" * 11)
            row = " ".join(["[]" for _ in page])
            album.append(row)
        album.append("-" * 11)

        return "\n".join(album)


album = PhotoAlbum(2)

print(album.add_photo("baby"))
print(album.add_photo("first grade"))
print(album.add_photo("eight grade"))
print(album.add_photo("party with friends"))
print(album.photos)
print(album.add_photo("prom"))
print(album.add_photo("wedding"))

print(album.display())
