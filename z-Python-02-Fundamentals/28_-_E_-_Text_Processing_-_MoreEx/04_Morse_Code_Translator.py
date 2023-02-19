# 100/100

def decode_letter(morse_letter: str):
    morse = {
        ".-": "A",
        "-...": "B",
        "-.-.": "C",
        "-..": "D",
        ".": "E",
        "..-.": "F",
        "--.": "G",
        "....": "H",
        "..": "I",
        ".---": "J",
        "-.-": "K",
        ".-..": "L",
        "--": "M",
        "-.": "N",
        "---": "O",
        ".--.": "P",
        "--.-": "Q",
        ".-.": "R",
        "...": "S",
        "-": "T",
        "..-": "U",
        "...-": "V",
        ".--": "W",
        "-..-": "X",
        "-.--": "Y",
        "--..": "Z"
    }
    return morse[morse_letter]


def decode_word(morse_word: str):
    decoded_word = ''
    morse_letters = morse_word.split()
    for morse_letter in morse_letters:
        decoded_word += decode_letter(morse_letter)
    return decoded_word


message = input()
words = message.split(' | ')

decoded_message = []
for word in words:
    word = decode_word(word)
    decoded_message.append(word)

print(' '.join(decoded_message))
