# 100/100

from project.hotel import Hotel
from project.room import Room

hotel = Hotel.from_stars(5)

first_room = Room(1, 3)
second_room = Room(2, 2)
third_room = Room(3, 1)

print(hotel.add_room(first_room))
print(hotel.add_room(second_room))
print(hotel.add_room(third_room))
# print(hotel.rooms)

hotel.take_room(1, 4)
hotel.take_room(1, 2)
hotel.take_room(3, 1)
hotel.take_room(3, 1)

print(hotel.status())
