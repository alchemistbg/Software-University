from project.services.base_service import BaseService


class SecondaryService(BaseService):
	MAX_CAPACITY = 15

	def __init__(self, name: str):
		super().__init__(name, capacity = self.MAX_CAPACITY)

	def details(self):
		return f"{self.name} Secondary Service:\nRobots: {self._get_robots_names()}"

