# https://judge.softuni.org/Contests/Practice/Index/2525#0
# 100/100

# This solution uses string manipulations. I tried converting input to a deque, but got only 83/100
msg = input()

while True:
    command = input()

    if command == "Decode":
        break

    tokens = command.split('|')
    if tokens[0] == 'Move':
        num_letters = int(tokens[1])
        msg = msg[num_letters:] + msg[:num_letters]
    elif tokens[0] == 'Insert':
        idx = int(tokens[1])
        letter = tokens[2]
        msg = msg[:idx] + letter + msg[idx:]
    elif tokens[0] == 'ChangeAll':
        old_letter = tokens[1]
        new_letter = tokens[2]
        msg = msg.replace(old_letter, new_letter)

print(f"The decrypted message is: {''.join(msg)}")
