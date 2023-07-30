class Hardware:

	def __init__(self, name: str, hardware_type: str, capacity: int, memory: int):
		self.name = name
		self.hardware_type = hardware_type
		self.capacity = capacity
		self.memory = memory

	def install(self, software):
		pass

	def uninstall(self, software):
		pass
