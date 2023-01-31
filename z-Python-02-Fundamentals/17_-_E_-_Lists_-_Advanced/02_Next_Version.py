# 100/100

current_version = input()
# This is my solution
# major, minor, patch = current_version.split('.')
#
# major = int(major)
# minor = int(minor)
# patch = int(patch)
#
# patch += 1
# if patch == 10:
#     patch = 0
#     minor += 1
# if minor == 10:
#     minor = 0
#     major += 1
#
# print(f'{major}.{minor}.{patch}')

# This is idea from the lector it is clever
current_version = current_version.replace('.', '')
current_version_number = int(current_version)
next_version_number = current_version_number + 1
next_version = list(str(next_version_number))
next_version_string = '.'.join(next_version)
print(next_version_string)