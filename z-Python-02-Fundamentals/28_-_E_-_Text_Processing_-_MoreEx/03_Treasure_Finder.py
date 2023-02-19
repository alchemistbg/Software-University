# 100/100

key = list(map(int, input().split()))

while True:
    message = input()
    if message == 'find':
        break

    message_list = list(message)

    key_length = len(key)
    for idx, ch in enumerate(message_list):
        num = key[idx % key_length]
        message_list[idx] = chr(ord(ch) - num)

    decoded_message = ''.join(message_list)

    material_start = decoded_message.index('&') + 1
    material_end = decoded_message.index('&', material_start + 1)
    material_type = decoded_message[material_start:material_end]

    coordinates_start = decoded_message.index('<') + 1
    coordinates_end = decoded_message.index('>')
    coordinates = decoded_message[coordinates_start:coordinates_end]

    print(f'Found {material_type} at {coordinates}')
