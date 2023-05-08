from typing import List
from .room import Room

class Hotel:

    def __init__(self, name: str):
        self.name: str = name
        self.rooms: [Room] = []
        self.guests: int = 0

    def _find_room_by_number(self, room_number: int):
        room = [r for r in self.rooms if r.number == room_number]
        if room:
            return room[0]

    @classmethod
    def from_stars(cls, stars_count: int):
        name = f"{stars_count} stars Hotel"
        return cls(name)

    def add_room(self, room: Room):
        self.rooms.append(room)

    def take_room(self, room_number: int, people: int):
        room_to_take = self._find_room_by_number(room_number)
        if room_to_take:
            result = room_to_take.take_room(people)
            # if not isinstance(result, str):
            if result is None:
                self.guests += people

    def free_room(self, room_number):
        room_to_free = self._find_room_by_number(room_number)
        if room_to_free:
            people = room_to_free.guests
            result = room_to_free.free_room()
            # if not isinstance(result, str):
            if result is None:
                self.guests -= people

    def status(self):
        header = f"Hotel {self.name} has {self.guests} total guests"
        free_rooms = f'Free rooms: {", ".join([str(r.number) for r in self.rooms if not r.is_taken])}'
        taken_rooms = f'Taken rooms: {", ".join([str(r.number) for r in self.rooms if r.is_taken])}'
        return "\n".join((header, free_rooms, taken_rooms))

