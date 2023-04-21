# from song import Song
# from album import Album

class Band:
    def __init__(self, name: str):
        self.name = name
        self.albums = []

    def __get_albums_names(self):
        return [album.name for album in self.albums]

    def add_album(self, album_to_add):
        if album_to_add.name in self.__get_albums_names():
            return f"Band {self.name} already has {album_to_add.name} in their library."

        self.albums.append(album_to_add)
        return f"Band {self.name} has added their newest album {album_to_add.name}."

    def remove_album(self, album_to_remove_name):
        album_names = self.__get_albums_names()

        if album_to_remove_name not in album_names:
            return f"Album {album_to_remove_name} is not found."

        album_to_remove_idx = album_names.index(album_to_remove_name)

        if self.albums[album_to_remove_idx].published:
            return f"Album has been published. It cannot be removed."

        removed_album = self.albums.pop(album_to_remove_idx)
        return f"Album {album_to_remove_name} has been removed."

    def details(self):
        band_info = [f"Band {self.name}"]
        albums_info = [f"{album.details()}" for album in self.albums]
        return "\n".join(band_info + albums_info)
