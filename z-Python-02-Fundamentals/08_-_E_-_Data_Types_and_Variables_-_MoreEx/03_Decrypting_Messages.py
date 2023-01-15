# 100/100

key = int(input())
lines = int(input())

message = ''

while lines > 0:
    encoded_letter = ord(input())
    decoded_letter = encoded_letter + key
    message += chr(decoded_letter)
    lines -= 1

print(message)