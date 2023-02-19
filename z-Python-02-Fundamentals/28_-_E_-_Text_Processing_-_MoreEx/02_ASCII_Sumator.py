# 100/100

start_ascii_idx = ord(input())
end_ascii_idx = ord(input())
text = input()

ascii_sum = 0

for ch in text:
    ch_ascii_code = ord(ch)
    if start_ascii_idx < ch_ascii_code < end_ascii_idx:
        ascii_sum += ch_ascii_code

print(ascii_sum)
