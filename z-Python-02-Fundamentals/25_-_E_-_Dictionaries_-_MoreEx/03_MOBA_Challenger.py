# 100/100

players = {}

while True:
    data = input()
    if data == 'Season end':
        break

    if ' -> ' in data:
        player, position, skills = data.split(' -> ')
        skills = int(skills)

        if not players.get(player):
            players[player] = {}
            players[player]['total'] = 0

        if not players[player].get(position):
            players[player][position] = 0

        if skills > players[player][position]:
            players[player]['total'] += skills
            players[player]['total'] -= players[player][position]
            players[player][position] = skills

    if ' vs ' in data:
        p1, p2 = data.split(' vs ')

        if (players.get(p1) and players.get(p2) and
                len(set(players[p1].keys()).intersection(set(players[p2].keys()))) > 1):

            if players[p1]['total'] > players[p2]['total']:
                players.pop(p2)
                continue

            players.pop(p1)

sorted_players = dict(sorted(players.items(), key = lambda kvp: (-kvp[1]['total'], kvp[0])))
for player in sorted_players:
    print(f'{player}: {players[player]["total"]} skill')
    ordered_skills = dict(sorted(players[player].items(), key = lambda kvp: (-kvp[1], kvp[0])))
    for position in ordered_skills:
        if position != 'total':
            print(f'- {position} <::> {players[player][position]}')
