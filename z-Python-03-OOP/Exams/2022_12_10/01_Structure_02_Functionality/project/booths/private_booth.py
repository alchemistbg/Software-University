from project.booths.booth import Booth


class PrivateBooth(Booth):
	PRICE_PER_PERSON = 3.50

	def reserve(self, number_of_people: int):
		total_price = number_of_people * PrivateBooth.PRICE_PER_PERSON
		self.price_for_reservation = total_price
		self.is_reserved = True
