from project.user import User
from project.route import Route
from project.vehicles.base_vehicle import BaseVehicle
from project.vehicles.passenger_car import PassengerCar
from project.vehicles.cargo_van import CargoVan


class ManagingApp:

	def __init__(self):
		self.users = []
		self.vehicles = []
		self.routes = []

	def register_user(self, first_name: str, last_name: str, driving_license_number: str):
		# print(locals().keys())
		# pass
		if self._find_item(self.users, 'driving_license_number', driving_license_number):
			return f"{driving_license_number} has already been registered to our platform."
		user = User(first_name, last_name, driving_license_number)
		self.users.append(user)
		return f"{first_name} {last_name} was successfully registered under DLN-{driving_license_number}"

	def upload_vehicle(self, vehicle_type: str, brand: str, model: str, license_plate_number: str):
		vehicles = {
			"PassengerCar": PassengerCar, "CargoVan": CargoVan
		}
		if vehicle_type not in vehicles:
			return f"Vehicle type {vehicle_type} is inaccessible."
		elif self._find_item(self.vehicles, 'license_plate_number', license_plate_number):
			return f"{license_plate_number} belongs to another vehicle."
		else:
			vehicle = vehicles[vehicle_type](brand, model, license_plate_number)
			self.vehicles.append(vehicle)
			return f"{brand} {model} was successfully uploaded with LPN-{license_plate_number}."

	def allow_route(self, start_point: str, end_point: str, length: float):
		routes = [route for route in self.routes if route.start_point == start_point and route.end_point == end_point and route.length <= length]
		if routes:
			if routes[0].length == length:
				return f"{start_point}/{end_point} - {length} km had already been added to our platform."
			else:
				return f"{start_point}/{end_point} shorter route had already been added to our platform."

		else:
			# TODO - Need to be refactored
			longer_routes = [route for route in self.routes if route.start_point == start_point and route.end_point == end_point and route.length > length]
			if longer_routes:
				longer_routes[0].is_locked = True
			route_id = len(self.routes) + 1
			route = Route(start_point, end_point, length, route_id)
			self.routes.append(route)
			return f"{start_point}/{end_point} - {length} km is unlocked and available to use."

	def make_trip(self, driving_license_number: str, license_plate_number: str, route_id: int,  is_accident_happened: bool):
		user: User = self._find_item(self.users, "driving_license_number", driving_license_number)
		vehicle: BaseVehicle = self._find_item(self.vehicles, "license_plate_number", license_plate_number)
		route: Route = self._find_item(self.routes, "route_id", route_id)
		if user.is_blocked:
			return f"User {driving_license_number} is blocked in the platform! This trip is not allowed."
		elif vehicle.is_damaged:
			return f"Vehicle {license_plate_number} is damaged! This trip is not allowed."
		elif route.is_locked:
			return f"Route {route_id} is locked! This trip is not allowed."
		else:
			vehicle.drive(route.length)
			if is_accident_happened:
				vehicle.is_damaged = True
				user.decrease_rating()
			else:
				user.increase_rating()
			return str(vehicle)

	def repair_vehicles(self, count: int):
		sorted_vehicles = self._sort_vehicles()
		broken_vehicles = [v for v in sorted_vehicles if v.is_damaged][0:count]

		for bv in broken_vehicles:
			bv.change_status()
			bv.recharge()

		return f"{len(broken_vehicles)} vehicles were successfully repaired!"

	def users_report(self):
		output = []
		output.append("*** E-Drive-Rent ***")
		output.extend([str(user) for user in sorted(self.users, key = lambda user: user.rating, reverse = True)])
		return "\n".join(output)

	def _find_item(self, collection, prop_name, prop_value):
		results = [item for item in collection if getattr(item, prop_name) == prop_value]
		if not results:
			return None

		return results[0]

	def _sort_vehicles(self):
		return sorted(self.vehicles, key=lambda v: (v.brand, v.model))


