# 100/100

def has_side(user_side, force: dict):
    return user_side in force.keys()


def has_user(user_name, force: dict):
    is_in = False

    for user_side in force.keys():
        if user_name in force[user_side]:
            is_in = True
            break

    return is_in


def find_user_side(user_name, force: dict):
    for side in force.keys():
        if user_name in force[side]:
            return side


force = {}

while True:
    data = input()
    if data == 'Lumpawaroo':
        break

    to_edit = False

    if ' | ' in data:
        side, user = data.split(' | ')
    else:
        user, side = data.split(' -> ')
        to_edit = True

    if not has_side(side, force):
        force[side] = []

    if not has_user(user, force):
        force[side].append(user)

    if has_user(user, force) and to_edit:
        old_side = find_user_side(user, force)
        force[old_side].remove(user)
        force[side].append(user)
        print(f'{user} joins the {side} side!')


for side_key in force.keys():
    users_value = force[side_key]
    if len(users_value) > 0:
        print(f'Side: {side_key}, Members: {len(users_value)}')
        [print(f'! {user_value}') for user_value in users_value]
