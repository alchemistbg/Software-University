# 100/100

class Email:
    def __init__(self, sender, receiver, content, is_sent = False):
        self.sender = sender
        self.receiver = receiver
        self.content = content
        self.is_sent = is_sent

    def send(self):
        self.is_sent = True

    def get_info(self):
        return f'{self.sender} says to {self.receiver}: {self.content}. Sent: {self.is_sent}'


emails = []
while True:
    email_data = input().split()

    if email_data[0] == 'Stop':
        break

    [sender, receiver, content] = email_data
    email = Email(sender, receiver, content)
    emails.append(email)

sended_emails = [int(idx) for idx in input().split(', ')]
for sended_idx in sended_emails:
    emails[sended_idx].send()


for email in emails:
    print(email.get_info())
