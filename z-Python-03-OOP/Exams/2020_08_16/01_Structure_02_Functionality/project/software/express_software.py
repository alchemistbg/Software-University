from .software import Software


class ExpressSoftware(Software):

	def __init__(self, name: str, software_type: str, capacity_consumption: int, memory_consumption: int):
		super().__init__(
			name = name,
			software_type = 'Express',
			capacity_consumption = capacity_consumption,
			memory_consumption = int(memory_consumption * 2)
		)
