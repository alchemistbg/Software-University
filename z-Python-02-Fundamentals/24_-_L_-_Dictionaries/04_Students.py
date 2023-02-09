# 100/100

students = {}
query_course = ''

while True:
    input_data = input()
    if ':' not in input_data:
        query_course = input_data.replace('_', ' ')
        break

    name, id, course = input_data.split(':')
    students[id] = (name, course)

for id in students.keys():
    if query_course in students[id]:
        print(f'{students[id][0]} - {id}')