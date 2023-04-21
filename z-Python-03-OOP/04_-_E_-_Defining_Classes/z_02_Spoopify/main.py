# 100/100
# This main file was created to test the objects

from project.song import Song
from project.album import Album
from project.band import Band

if __name__ == '__main__':
    song1 = Song("Running in the 90s", 3.45, False)
    print(song1.get_info())
    song2 = Song("Running in the 00s", 4.45, False)
    album = Album("Initial D", song1)
    print(album.add_song(song2))
    second_song = Song("Around the World", 2.34, False)
    print(album.add_song(second_song))
    print(album.details())
    print(album.publish())
    band = Band("Manuel")
    print(band.add_album(album))
    print(band.remove_album("Initial D"))
    print(band.details())
