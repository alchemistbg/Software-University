# 100/100

phonebook = {}

while True:
    text = input()
    if '-' not in text:
        counter = int(text)
        break

    name, phone = text.split('-')
    phonebook[name] = phone


for _ in range(counter):
    query = input()
    if phonebook.get(query):
        print(f'{query} -> {phonebook[query]}')
    else:
        print(f'Contact {query} does not exist.')
