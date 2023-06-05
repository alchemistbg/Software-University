# 100/100

from abc import ABC, abstractmethod


class Instrument(ABC):

	@abstractmethod
	def play(self):
		pass


class Guitar(Instrument):

	def play(self) -> str:
		return "Playing the guitar"


class Piano(Instrument):

	def play(self):
		return "Playing the piano"


class Children(Instrument):

	def play(self) -> str:
		return "Children are playing"


def start_playing(instrument: 'Instrument'):
	return instrument.play()


guitar = Guitar()
print(start_playing(guitar))

piano = Piano()
print(start_playing(piano))

children = Children()
print(start_playing(children))
