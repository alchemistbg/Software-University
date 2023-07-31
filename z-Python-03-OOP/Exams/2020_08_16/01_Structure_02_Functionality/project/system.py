from project.software.software import Software
from project.software.light_software import LightSoftware
from project.software.express_software import ExpressSoftware
from project.hardware.hardware import Hardware
from project.hardware.power_hardware import PowerHardware
from project.hardware.heavy_hardware import HeavyHardware


class System:

	_hardware = []
	_software = []

	@staticmethod
	def register_power_hardware(name: str, capacity: int, memory: int):
		ph = PowerHardware(name, capacity, memory)
		System._hardware.append(ph)

	@staticmethod
	def register_heavy_hardware(name: str, capacity: int, memory: int):
		hh = HeavyHardware(name, capacity, memory)
		System._hardware.append(hh)

	@staticmethod
	def register_express_software(hardware_name: str, name: str, capacity_consumption: int, memory_consumption: int):
		hw = System._find_by_name(hardware_name, System._hardware)
		if not hw:
			return "Hardware does not exist"
		es = ExpressSoftware(name, capacity_consumption, memory_consumption)
		hw.install(es)
		System._software.append(es)

	@staticmethod
	def register_light_software(hardware_name: str, name: str, capacity_consumption: int, memory_consumption: int):
		hw = System._find_by_name(hardware_name, System._hardware)
		if not hw:
			return "Hardware does not exist"
		ls = LightSoftware(name, capacity_consumption, memory_consumption)
		hw.install(ls)
		System._software.append(ls)

	@staticmethod
	def release_software_component(hardware_name: str, software_name: str):
		hw = System._find_by_name(hardware_name, System._hardware)
		sw = System._find_by_name(software_name, System._software)
		if not hw or not sw:
			return "Some of the components do not exist"
		hw.uninstall(sw)
		System._software.remove(sw)

	@staticmethod
	def analyze():
		output = []
		total_memory_consumption = sum([sw.memory_consumption for sw in System._software])
		total_memory = sum([hw.memory for hw in System._hardware])
		total_capacity_consumption = sum([sw.capacity_consumption for sw in System._software])
		total_capacity = sum([hw.capacity for hw in System._hardware])
		output.append("System Analysis")
		output.append(f"Hardware Components: {len(System._hardware)}")
		output.append(f"Software Components: {len(System._software)}")
		output.append(f"Total Operational Memory: {total_memory_consumption} / {total_memory}")
		output.append(f"Total Capacity Taken: {total_capacity_consumption} / {total_capacity}")
		return "\n".join(output)

	@staticmethod
	def system_split():
		output = []
		for hw in System._hardware:
			output.append(str(hw))
		return "\n".join(output)

	@classmethod
	def _find_by_name(cls, name, collection):
		hw = [hw for hw in collection if hw.name == name]
		if not hw:
			return None
		return hw[0]


