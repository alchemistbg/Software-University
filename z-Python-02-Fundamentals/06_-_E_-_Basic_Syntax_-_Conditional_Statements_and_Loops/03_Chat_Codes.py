# 100/100

msgs = int(input())

counter = 0

while counter < msgs:
    msg = int(input())
    if msg == 88:
        print('Hello')
    elif msg == 86:
        print('How are you?')
    elif msg < 88:
        print('GREAT!')
    else:
        print('Bye.')

    counter += 1
