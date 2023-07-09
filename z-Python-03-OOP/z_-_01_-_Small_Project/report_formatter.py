import sys
import io
from typing import List, Tuple
from datetime import datetime
import matplotlib.pyplot as plt
from email import encoders
from email.mime.base import MIMEBase
from email.mime.multipart import MIMEMultipart


def plain_text_format(report: List[Tuple[datetime, List[float]]]):
	return '\n'.join([
		f"{time.strftime('%H:%M:%S.%f')} {measurement}"
		for time, measurement in report
	])


def line_chart_format(report: List[Tuple[datetime, float]]):
	time = [time for time, _ in report]
	measurements = [measurement for _, measurement in report]

	plt.plot(time, measurements, color = 'green')
	plt.xlabel('Time')
	plt.xticks(rotation = 45)
	plt.ylabel('CPU Load (%)')
	plt.title('CPU Report')

	pdf_file = io.BytesIO()
	plt.savefig(pdf_file, bbox_inches = 'tight', format = 'pdf')

	email = MIMEMultipart()
	part = MIMEBase('application', "octet-stream")
	part.set_payload(pdf_file.getvalue())
	encoders.encode_base64(part)
	part.add_header(
		"Content-Disposition",
		"attachment; filename = report.pdf",
	)
	email.attach(part)
	return email
