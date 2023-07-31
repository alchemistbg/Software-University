from project.software.software import Software


class Hardware:

	def __init__(self, name: str, hardware_type: str, capacity: int, memory: int):
		self.name = name
		self.hardware_type = hardware_type
		self.capacity = capacity
		self.memory = memory
		self.software_components = []

	def install(self, software: Software):
		if self.capacity - software.capacity_consumption < 0 or \
				self.memory - software.memory_consumption < 0:
			raise Exception("Software cannot be installed")

		# self.capacity -= software.capacity_consumption
		# self.memory -= software.memory_consumption
		self.software_components.append(software)

	def uninstall(self, software: Software):
		if software in self.software_components:
			self.software_components.remove(software)
			# self.capacity += software.capacity_consumption
			# self.memory += software.memory_consumption

	def __str__(self):
		output = []
		output.append(f"Hardware Component - {self.name}")
		express_software_count = self._count_software_components_by_type("Express")
		output.append(f"Express Software Components: {express_software_count}")
		light_software_count = self._count_software_components_by_type('Light')
		output.append(f"Light Software Components: {light_software_count}")
		total_used_memory = self._calc_total_used_resource("memory_consumption")
		output.append(f"Memory Usage: {total_used_memory} / {self.memory}")
		total_used_capacity = self._calc_total_used_resource("capacity_consumption")
		output.append(f"Capacity Usage: {total_used_capacity} / {self.capacity}")
		output.append(f"Type: {self.hardware_type}")
		software_components_names = self._get_software_components_names()
		output.append(f"Software Components: {software_components_names}")
		return "\n".join(output)

	def _count_software_components_by_type(self, sw_component_type):
		software_components = [sc for sc in self.software_components if sc.software_type == sw_component_type]
		return len(software_components)

	def _calc_total_used_resource(self, resource):
		used_resources = [getattr(sw, resource) for sw in self.software_components]
		sum_used_resources = sum(used_resources)
		return sum_used_resources

	def _get_software_components_names(self):
		names = [sc.name for sc in self.software_components]
		if not names:
			return None
		return ", ".join(names)
