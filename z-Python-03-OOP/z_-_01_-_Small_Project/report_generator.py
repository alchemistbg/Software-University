from datetime import datetime, timedelta
import psutil


def generate_report(duration: timedelta):
	measurements = []
	cpu_counts = psutil.cpu_count(logical=True)

	begin_time = datetime.now()
	end_time = begin_time + duration
	now = datetime.now()
	while now < end_time:
		# curr_measurement = (now, psutil.cpu_percent(interval = 0.1, percpu = True))
		curr_measurement = (now, psutil.cpu_percent(interval = 0.1))
		measurements.append(curr_measurement)
		now = datetime.now()

	return measurements
