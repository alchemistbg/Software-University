from typing import List
from project.rooms.room import Room


class Everland:

	def __init__(self):
		self.rooms: List[Room] = []

	def add_room(self, room: Room):
		self.rooms.append(room)

	def get_monthly_consumptions(self):
		total_expenses = 0
		for room in self.rooms:
			total_expenses += room.room_cost + room.expenses
		return f'Monthly consumption: {total_expenses:.2f}$.'

	def pay(self):
		result = []
		rooms_to_delete = []
		for room in self.rooms:
			room_total_cost = room.expenses + room.room_cost
			if room.budget < room_total_cost:
				message = f"{room.family_name} does not have enough budget and must leave the hotel."
				rooms_to_delete.append(room)
			else:
				room.budget -= room_total_cost
				message = f"{room.family_name} paid {room_total_cost:.2f}$ and have {room.budget:.2f}$ left."
			result.append(message)
		self.__delete_rooms(rooms_to_delete)
		return '\n'.join(result)

	def __delete_rooms(self, rooms_to_delete: List[Room]):
		for room in rooms_to_delete:
			self.rooms.remove(room)

	def status(self):
		info = []
		total_population = 0

		for room in self.rooms:
			total_population += room.members_count

			family_info = f"{room.family_name} with {room.members_count} members. " \
						  f"Budget: {room.budget:.2f}$, " \
						  f"Expenses: {room.expenses}$"
			info.append(family_info)

			for idx, child in enumerate(room.children, 1):
				child_info = f"--- Child {idx + 1} monthly cost: {(child.cost * 30):.2f}$"
				info.append(child_info)

			appliance_info = f"--- Appliances monthly cost: {room.expenses:.2f}$"
			info.append(appliance_info)

		info.insert(0, f'Total population: {total_population}')

		return '\n'.join(info)
