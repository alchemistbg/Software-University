import os
import smtplib
import ssl
from email.message import EmailMessage


def send_email(formatted_report: str):

	username = os.environ.get('GOOGLE_EMAIL_USERNAME')
	password = os.environ.get('GOOGLE_EMAIL_PASSWORD')

	subject = "CPU loading report"
	body = formatted_report

	email = EmailMessage()
	email['From'] = username
	email['To'] = username
	email['Subject'] = subject
	email.set_content(body)

	context = ssl.create_default_context()

	with smtplib.SMTP_SSL('smtp.gmail.com', 465, context = context) as smtp:
		smtp.login(username, password)
		smtp.sendmail(username, username, email.as_string())
