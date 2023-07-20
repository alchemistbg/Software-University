from .computer import Computer


class DesktopComputer(Computer):
	processors = {
		"AMD Ryzen 7 5700G": 500,
		"Intel Core i5-12600K": 600,
		"Apple M1 Max": 1800,
	}

	valid_ram = [2, 4, 8, 16, 32, 64, 128]

	type = 'desktop computer'
