from typing import List, Union

from project.robots.base_robot import BaseRobot
from project.services.base_service import BaseService

from project.robots.male_robot import MaleRobot
from project.robots.female_robot import FemaleRobot
from project.services.main_service import MainService
from project.services.secondary_service import SecondaryService


class RobotsManagingApp:

	SERVICE_TYPES = {"MainService": MainService, "SecondaryService": SecondaryService}
	ROBOT_TYPES = {"MaleRobot": MaleRobot, "FemaleRobot": FemaleRobot}

	def __init__(self):
		self.robots = []
		self.services = []

	def add_service(self, service_type: str, name: str):
		if service_type not in self.SERVICE_TYPES:
			raise Exception("Invalid service type!")
		service = self.SERVICE_TYPES[service_type](name)
		self.services.append(service)
		return f"{service_type} is successfully added."

	def add_robot(self, robot_type: str, name: str, kind: str, price: float):
		if robot_type not in self.ROBOT_TYPES:
			raise Exception("Invalid robot type!")
		robot = self.ROBOT_TYPES[robot_type](name, kind, price)
		self.robots.append(robot)
		return f"{robot_type} is successfully added."

	def add_robot_to_service(self, robot_name: str, service_name: str):
		robot = self._find_by_name(robot_name, self.robots)
		service = self._find_by_name(service_name, self.services)
		if robot.POSSIBLE_SERVICE != service.__class__.__name__:
			return "Unsuitable service."

		if len(service.robots) >= service.capacity:
			raise Exception("Not enough capacity for this robot!")

		self.robots.remove(robot)
		service.robots.append(robot)
		return f"Successfully added {robot.name} to {service.name}."

	def remove_robot_from_service(self, robot_name: str, service_name: str):
		service = self._find_by_name(service_name, self.services)
		robot = self._find_by_name(robot_name, service.robots)

		if not robot:
			raise Exception("No such robot in this service!")

		service.robots.remove(robot)
		self.robots.append(robot)
		return f"Successfully removed {robot_name} from {service_name}."

	def feed_all_robots_from_service(self, service_name: str):
		service = self._find_by_name(service_name, self.services)
		[r.eating() for r in service.robots]
		return f"Robots fed: {len(service.robots)}."

	def service_price(self, service_name: str):
		service = self._find_by_name(service_name, self.services)
		robots_price = sum([r.price for r in service.robots])
		return f"The value of service {service_name} is {robots_price:.2f}."

	def __str__(self):
		return "\n".join([s.details() for s in self.services])

	def _find_by_name(self, obj_name: str, collection):
		result = [o for o in collection if o.name == obj_name]
		if not result:
			return None
		return result[0]
