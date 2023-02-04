# 100/100

class Party:
    def __init__(self):
        self.people = []

    def add_people(self, name):
        self.people.append(name)

    def get_people_names_as_string(self, separator = ' '):
        return f'{separator}'.join(self.people)

    def get_people_count(self):
        return len(self.people)


party = Party()
while True:
    name = input()
    if name == 'End':
        break

    party.add_people(name)

people_names = party.get_people_names_as_string(', ')
people_count = party.get_people_count()

print(f'Going: {people_names}')
print(f'Total: {people_count}')