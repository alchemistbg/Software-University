# 100/100

# According to the lecturer, checking if something is in collections is faster with sets
vowels = {'a', 'o', 'u', 'e', 'i'}

s = input()
filtered_s = [char for char in s if char.lower() not in vowels]
print(''.join(filtered_s))
