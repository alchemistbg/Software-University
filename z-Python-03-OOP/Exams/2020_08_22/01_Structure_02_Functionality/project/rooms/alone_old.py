from .room import Room


class AloneOld(Room):
	room_cost = 10

	def __init__(self, family_name: str, pension: float):
		self.family_name = family_name
		self.pension = pension
		self.members_count = 1
		super().__init__(self.family_name, self.pension, self.members_count)
