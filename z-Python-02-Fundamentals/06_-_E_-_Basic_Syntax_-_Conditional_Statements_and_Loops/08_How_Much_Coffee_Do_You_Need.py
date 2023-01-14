s = input()

coffee_counts = 0

# events = ['coding', 'cat', 'dog', 'movie']
# while s != 'END':
#     if s.lower() in events and not s.isupper():
#         coffee_counts += 1
#     if s.lower() in events and s.isupper():
#         coffee_counts += 2
#     s = input()

events_lower = ['coding', 'cat', 'dog', 'movie']
events_upper = ['CODING', 'CAT', 'DOG', 'MOVIE']
while s != 'END':
    if s in events_lower:
        coffee_counts += 1
    if s in events_upper:
        coffee_counts += 2
    s = input()

if coffee_counts <= 5:
    print(coffee_counts)
else:
    print('You need extra sleep')
