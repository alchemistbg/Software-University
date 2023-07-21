from .computer import Computer


class DesktopComputer(Computer):
	processors = {
		"AMD Ryzen 7 5700G": 500,
		"Intel Core i5-12600K": 600,
		"Apple M1 Max": 1800,
	}

	valid_ram = [2, 4, 8, 16, 32, 64, 128]

	def configure_computer(self, processor: str, ram: int):

		if processor not in self.processors:
			raise ValueError(f"{processor} is not compatible with desktop computer {self.manufacturer} {self.model}!")

		if ram not in self.valid_ram or ram > self.__class__.valid_ram[-1]:
			raise ValueError(f"{ram}GB RAM is not compatible with desktop computer {self.manufacturer} {self.model}!")

		# self.processor = processor
		# self.ram = ram

		self.set_props(processor, ram)

		return f"Created {self.manufacturer} {self.model} with {processor} and {ram}GB RAM for {self.price}$."
