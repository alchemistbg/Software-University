from project.band import Band
from project.band_members.musician import Musician
from project.band_members.singer import Singer
from project.band_members.guitarist import Guitarist
from project.band_members.drummer import Drummer
from project.concert import Concert


class ConcertTrackerApp:
	MUSICIAN_TYPES = {"Guitarist": Guitarist, "Drummer": Drummer, "Singer": Singer}

	def __init__(self):
		self.bands = []
		self.musicians = []
		self.concerts = []

	def create_musician(self, musician_type: str, name: str, age: int):
		if musician_type not in self.MUSICIAN_TYPES:
			raise ValueError("Invalid musician type!")
		elif name in [m.name for m in self.musicians]:
			raise Exception(f"{name} is already a musician!")
		else:
			musician = self.MUSICIAN_TYPES[musician_type](name, age)
			self.musicians.append(musician)
			return f"{name} is now a {musician_type}."

	def create_band(self, name: str):
		if name in [b.name for b in self.bands]:
			raise Exception(f"{name} band is already created!")
		else:
			band = Band(name)
			self.bands.append(band)
			return f"{name} was created."

	def create_concert(self, genre: str, audience: int, ticket_price: float, expenses: float, place: str):
		if place in [c.place for c in self.concerts]:
			c = [c for c in self.concerts if c.place == place][0]
			raise Exception(f"{place} is already registered for {c.genre} concert!")
		else:
			concert = Concert(genre, audience, ticket_price, expenses, place)
			self.concerts.append(concert)
			return f"{genre} concert in {place} was added."

	def add_musician_to_band(self, musician_name: str, band_name: str):
		if musician_name not in [m.name for m in self.musicians]:
			raise Exception(f"{musician_name} isn't a musician!")
		elif band_name not in [b.name for b in self.bands]:
			raise Exception(f"{band_name} isn't a band!")
		else:
			musician = [m for m in self.musicians if m.name == musician_name][0]
			band = [b for b in self.bands if b.name == band_name][0]
			band.members.append(musician)
			return f"{musician_name} was added to {band_name}."

	def remove_musician_from_band(self, musician_name: str, band_name: str):
		if band_name not in [b.name for b in self.bands]:
			raise Exception(f"{band_name} isn't a band!")

		band = [b for b in self.bands if b.name == band_name][0]
		if musician_name not in [m.name for m in band.members]:
			raise Exception(f"{musician_name} isn't a member of {band_name}!")

		musician = [m for m in band.members if m.name == musician_name][0]
		band.members.remove(musician)
		return f"{musician_name} was removed from {band_name}."

	def start_concert(self, concert_place: str, band_name: str):
		band = [b for b in self.bands if b.name == band_name][0]
		concert = [c for c in self.concerts if c.place == concert_place][0]

		if not set(list(self.MUSICIAN_TYPES.keys())) == set([m.__class__.__name__ for m in band.members]):
			raise Exception(f"{band_name} can't start the concert because it doesn't have enough members!")

		skills_map = {
			"Rock": {'play the drums with drumsticks', 'sing high pitch notes', 'play rock'},
			"Metal": {'play the drums with drumsticks', 'sing low pitch notes', 'play metal'},
			"Jazz": {'play the drums with drum brushes', 'sing high pitch notes', 'sing low pitch notes', 'play jazz'}
		}
		band_skills = [skill for member in band.members for skill in member.skills]
		# for member in band.members:
		# 	for skill in member.skills:
		# 		band_skills.append(skill)
		band_skills = set(band_skills)
		# print(skills_map[concert.genre])
		# print(band_skills)
		# print(band_skills == skills_map[concert.genre])
		if not band_skills == skills_map[concert.genre]:
			raise Exception(f"The {band_name} band is not ready to play at the concert!")

		profit = (concert.audience * concert.ticket_price) - concert.expenses
		return f"{band_name} gained {profit:.2f}$ from the {concert.genre} concert in {concert.place}."
