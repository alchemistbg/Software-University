# 100/100

import re

decrypt_pattern = r'[star]'
message_pattern = r'@([A-Za-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A|D])![^@\-!:>]*->(\d+)[^@\-!:>]*'

attacked_planets = []
destroyed_planets = []

messages = int(input())
for _ in range (0, messages):
    enc_message = input()
    decrypt_matches = re.findall(decrypt_pattern, enc_message, re.IGNORECASE)
    key = len(decrypt_matches)

    decr_message = ''
    for ch in enc_message:
        decr_message += chr(ord(ch) - key)

    message_matches = re.finditer(message_pattern, decr_message)
    for message_match in message_matches:
        planet = message_match[1]
        population = int(message_match[2])
        attack_type = message_match[3]
        soldiers = int(message_match[4])
        if attack_type == 'A':
            attacked_planets.append(planet)
        else:
            destroyed_planets.append(planet)

attacked_planets.sort()
destroyed_planets.sort()
print(f'Attacked planets: {len(attacked_planets)}')
for attacked_planet in attacked_planets:
    print(f'-> {attacked_planet}')
print(f'Destroyed planets: {len(destroyed_planets)}')
for destroyed_planet in destroyed_planets:
    print(f'-> {destroyed_planet}')
