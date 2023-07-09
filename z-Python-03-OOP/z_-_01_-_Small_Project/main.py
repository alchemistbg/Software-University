from datetime import timedelta
from report_generator import generate_report
from report_formatter import plain_text_format, line_chart_format
from email_sender import send_email


class CpuReporter:

	def __init__(self, generator, formatter, sender):
		self.__generator = generator
		self.__reporter = formatter
		self.__sender = sender

	def send_report(self):
		report = self.__generator(timedelta(seconds = 10))
		formatted = self.__reporter(report)
		self.__sender(formatted)


def main():
	plain_text_reporter = CpuReporter(
		generator=generate_report,
		formatter=plain_text_format,
		sender=send_email
	)

	fancy_reporter = CpuReporter(
		generator=generate_report,
		formatter=line_chart_format,
		sender=send_email
	)

	fancy_reporter.send_report()


if __name__ == '__main__':
	main()
