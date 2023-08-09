from project.delicacies.gingerbread import Gingerbread
from project.delicacies.stolen import Stolen
from project.booths.open_booth import OpenBooth
from project.booths.private_booth import PrivateBooth


class ChristmasPastryShopApp:
	DELICACY_TYPES = {'Gingerbread': Gingerbread, 'Stolen': Stolen}
	BOOTH_TYPES = {'Open Booth': OpenBooth, 'Private Booth': PrivateBooth}

	def __init__(self):
		self.booths = []
		self.delicacies = []
		self.income = 0.0

	def add_delicacy(self, type_delicacy: str, name: str, price: float):
		if self._find_item_by_prop(self.delicacies, 'name', name):
			raise Exception(f"{name} already exists!")
		elif type_delicacy not in ChristmasPastryShopApp.DELICACY_TYPES:
			raise Exception(f"{type_delicacy} is not on our delicacy menu!")
		else:
			delicacy = ChristmasPastryShopApp.DELICACY_TYPES[type_delicacy](name, price)
			self.delicacies.append(delicacy)
			return f"Added delicacy {name} - {type_delicacy} to the pastry shop."

	def add_booth(self, type_booth: str, booth_number: int, capacity: int):
		if self._find_item_by_prop(self.booths, 'booth_number', booth_number):
			raise Exception(f"Booth number {booth_number} already exists!")
		elif type_booth not in ChristmasPastryShopApp.BOOTH_TYPES:
			raise Exception(f"{type_booth} is not a valid booth!")
		else:
			booth = ChristmasPastryShopApp.BOOTH_TYPES[type_booth](booth_number, capacity)
			self.booths.append(booth)
			return f"Added booth number {booth_number} in the pastry shop."

	def reserve_booth(self, number_of_people: int):
		booths = [booth for booth in self.booths if booth.capacity >= number_of_people and not booth.is_reserved]
		if not booths:
			raise Exception(f"No available booth for {number_of_people} people!")
		booths[0].reserve(number_of_people)
		return f"Booth {booths[0].booth_number} has been reserved for {number_of_people} people."

	def order_delicacy(self, booth_number: int, delicacy_name: str):
		booth = self._find_item_by_prop(self.booths, 'booth_number', booth_number)
		if not booth:
			raise Exception(f"Could not find booth {booth_number}!")

		delicacy = self._find_item_by_prop(self.delicacies, 'name', delicacy_name)
		if not delicacy:
			raise Exception(f"No {delicacy_name} in the pastry shop!")

		booth.delicacy_orders.append(delicacy)
		return f"Booth {booth_number} ordered {delicacy_name}."

	def leave_booth(self, booth_number: int):
		booth2 = self._find_item_by_prop(self.booths, 'booth_number', booth_number)
		# booth2 = [x for x in self.booths if x.booth_number == booth_number][0]
		ordered_items_price = sum([item.price for item in booth2.delicacy_orders])
		total_price = booth2.price_for_reservation + ordered_items_price
		self.income += total_price
		booth2.delicacy_orders = []
		booth2.price_for_reservation = 0.0
		booth2.is_reserved = False
		return f"Booth {booth_number}:\nBill: {total_price:.2f}lv."

	def get_income(self):
		return f"Income: {self.income:.2f}lv."

	def _find_item_by_prop(self, collection, prop_name, prop_value):
		result = [item for item in collection if getattr(item, prop_name) == prop_value]
		if not result:
			return None
		return result[0]
