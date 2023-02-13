# 100/100

companies = {}

while True:
    data = input()

    if data == 'End':
        break

    company, employee = data.split(' -> ')
    if company not in companies.keys():
        companies[company] = []

    if employee not in companies[company]:
        companies[company].append(employee)

for comp in companies:
    print(f'{comp}')
    [print(f'-- {emp}') for emp in (companies[comp])]
