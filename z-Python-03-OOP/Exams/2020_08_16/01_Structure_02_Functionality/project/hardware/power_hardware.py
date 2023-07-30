from .hardware import Hardware


class PowerHardware(Hardware):

	def __init__(self, name: str, hardware_type: str, capacity: int, memory: int):
		super().__init__(
			name = name,
			hardware_type = "Power",
			capacity = int(capacity * 0.25),
			memory = int(memory * 1.75)
		)
