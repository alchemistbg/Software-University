# 100/100

def check_ticket_validity(ticket):
    return len(ticket) == 20


def count_symbols(ticket: str, symbol):
    result = 0
    start = ticket.index(symbol)
    for idx in range(start, len(ticket)):
        if ticket[idx] != symbol:
            return result
        result += 1
    return result


def check_ticket_profit(ticket: str):
    left_side = ticket[0:10]
    right_side = ticket[10:]

    if '@' * 6 in left_side and '@' * 6 in right_side:
        return min(count_symbols(left_side, '@'), count_symbols(right_side, '@')), '@'
    elif '#' * 6 in left_side and '#' * 6 in right_side:
        return min(count_symbols(left_side, '#'), count_symbols(right_side, '#')), '#'
    elif '$' * 6 in left_side and '$' * 6 in right_side:
        return min(count_symbols(left_side, '$'), count_symbols(right_side, '$')), '$'
    elif '^' * 6 in left_side and '^' * 6 in right_side:
        return min(count_symbols(left_side, '^'), count_symbols(right_side, '^')), '^'
    else:
        return 0, ''


tickets = input().split(', ')

for ticket in tickets:
    ticket = ticket.strip()
    result = ''
    if not check_ticket_validity(ticket):
        print('invalid ticket')
    else:
        profit, symbol = check_ticket_profit(ticket)
        if profit == 0:
            result = f'ticket "{ticket}" - no match'
        elif profit < 10:
            result = f'ticket "{ticket}" - {profit}{symbol}'
        else:
            result = f'ticket "{ticket}" - {profit}{symbol} Jackpot!'

        print(result)
