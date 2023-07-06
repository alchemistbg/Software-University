from datetime import datetime
from typing import List, Tuple


def format_report(report: List[Tuple[datetime, float]]):
	return '\n'.join([
		f"{time.strftime('%H:%M:%S.%f')} {measurement}"
		for time, measurement in report
	])
