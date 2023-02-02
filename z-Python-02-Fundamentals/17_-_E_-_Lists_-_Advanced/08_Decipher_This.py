# 100/100
# This solution is unoptimized. Second comprehension could be removed with simple replace...TODO

coded_message = input().split()
decoded_message = []

for message_token in coded_message:
    # num_str = int(''.join([ch for ch in message_token if 48 <= ord(ch) <= 57]))
    num_str = int(''.join([ch for ch in message_token if ch.isnumeric()]))
    first_letter = chr(num_str)

    # text_str = [ch for ch in message_token if ord(ch) < 48 or ord(ch) > 57]
    text_str = [ch for ch in message_token if not ch.isnumeric()]
    text_str[0], text_str[-1] = text_str[-1], text_str[0]
    text_str = ''.join(text_str)

    decoded_message.append(first_letter + text_str)

print(' '.join(decoded_message))
