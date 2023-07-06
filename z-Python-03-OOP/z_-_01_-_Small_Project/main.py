from datetime import timedelta
from report_generator import generate_report
from report_formatter import format_report
from email_sender import send_email


def main():
	report = generate_report(timedelta(seconds = 1))
	formatted = format_report(report)
	send_email(formatted)


if __name__ == '__main__':
	main()
