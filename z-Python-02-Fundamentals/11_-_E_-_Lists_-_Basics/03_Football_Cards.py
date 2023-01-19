# 100/100

team_a = list([1] * 11)
team_b = list([1] * 11)

cards = input().split(' ')

message = ''

for card in cards:
    card_team, card_number = card.split('-')
    card_number = int(card_number)
    idx = card_number - 1

    if card_team == 'A':
        team_a[idx] = 0

    if card_team == 'B':
        team_b[idx] = 0

    team_a_size = sum(team_a)
    team_b_size = sum(team_b)
    message = f'Team A - {team_a_size}; Team B - {team_b_size}'
    if team_a_size < 7 or team_b_size < 7:
        message += '\nGame was terminated'
        break

print(message)
