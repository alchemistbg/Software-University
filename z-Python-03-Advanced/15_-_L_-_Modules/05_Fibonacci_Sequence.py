# I cannot test this solution, because the problem doesn't exist in the judge system

import fibonacci_module

# sequence = []

while True:
    command = input()
    if command.startswith('Create'):
        number = int(command.split()[-1])
        sequence = fibonacci_module.create_fibunacci_sequence(number)
        print(f'{", ".join(map(str, sequence))}')
    elif command.startswith('Locate'):
        number = int(command.split()[-1])
        try:
            position = sequence.index(number)
            print(f'The number - {number} is at index {position}.')
        except ValueError:
            print(f'The number {number} is not in the sequence!')
        except NameError:
            print(f'You should create a sequence first!')
    elif command == 'Stop':
        break