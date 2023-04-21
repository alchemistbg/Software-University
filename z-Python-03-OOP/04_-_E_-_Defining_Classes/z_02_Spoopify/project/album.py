# from song import Song

class Album:
    def __init__(self, name: str, *songs):
        self.name = name
        self.songs = list(songs)
        self.published = False

    def __get_songs_names(self):
        return [song.name for song in self.songs]

    def add_song(self, song_to_add) -> str:
        if song_to_add.single:
            return f"Cannot add {song_to_add.name}. It's a single"

        if self.published:
            return f"Cannot add songs. Album is published."

        if song_to_add.name in self.__get_songs_names():
            return "Song is already in the album."

        self.songs.append(song_to_add)
        return f"Song {song_to_add.name} has been added to the album {self.name}."

    def remove_song(self, song_to_remove_name: str) -> str:
        songs_names = self.__get_songs_names()
        if song_to_remove_name not in songs_names:
            return "Song is not in the album."

        if self.published:
            return "Cannot remove songs. Album is published."

        song_to_remove_idx = songs_names.index(song_to_remove_name)
        removed_song = self.songs.pop(song_to_remove_idx)
        return f"Removed song {removed_song.name} from album {self.name}."

    def publish(self) -> str:
        if self.published:
            return f"Album {self.name} is already published."

        self.published = True
        return f"Album {self.name} has been published."

    def details(self) -> str:
        album_info = [f"Album {self.name}"]
        songs_info = [f"== {song.get_info()}" for song in self.songs]

        return "\n".join(album_info + songs_info)
