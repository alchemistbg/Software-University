# 100/100

counter = int(input())

invited = set()

for _ in range(counter):
    code = input()
    invited.add(code)

arrived = set()
while True:
    data = input()
    if data == 'END':
        break

    arrived.add(data)

missing = invited - arrived
missing_sorted = sorted(missing)
print(len(missing))
print('\n'.join(missing_sorted))

# This is totally unnecessary
# counter = int(input())
#
# invited_vip = set()
# invited_regular = set()
#
# for _ in range(counter):
#     code = input()
#     if code[0].isdigit():
#         invited_vip.add(code)
#         continue
#     invited_regular.add(code)
#
# arrived_vip = set()
# arrived_regular = set()
# while True:
#     data = input()
#     if data == 'END':
#         break
#
#     if data[0].isdigit():
#         arrived_vip.add(data)
#         continue
#
#     arrived_regular.add(data)
#
# missing_vip = invited_vip - arrived_vip
# missing_vip_list = sorted(list(missing_vip))
# missing_regular = invited_regular - arrived_regular
# missing_regular_list = sorted(list(missing_regular))
# print(len(missing_vip_list) + len(missing_regular_list))
# print('\n'.join(missing_vip_list))
# print('\n'.join(missing_regular_list))
