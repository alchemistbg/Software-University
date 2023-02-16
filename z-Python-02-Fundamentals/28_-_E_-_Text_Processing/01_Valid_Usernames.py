# 100/100

usernames = input().split(', ')

valid_usernames = []

for username in usernames:
    if (3 <= len(username) <= 16) and (username.isalnum() or '-' in username or '_' in username) and (' ' not in username):
        valid_usernames.append(username)

print('\n'.join(valid_usernames))