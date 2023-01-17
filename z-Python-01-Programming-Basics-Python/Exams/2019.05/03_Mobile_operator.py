# 100/100

monthly_cost = 0.0

contract_duration = input()
contract_type = input()
mobile_net = input()
months = int(input())

if contract_duration == 'one':
    if contract_type == 'Small':
        monthly_cost = 9.98
    elif contract_type == 'Middle':
        monthly_cost = 18.99
    elif contract_type == 'Large':
        monthly_cost = 25.98
    else:
        monthly_cost = 35.99
else:
    if contract_type == 'Small':
        monthly_cost = 8.58
    elif contract_type == 'Middle':
        monthly_cost = 17.09
    elif contract_type == 'Large':
        monthly_cost = 23.59
    else:
        monthly_cost = 31.79

if mobile_net == 'yes':
    if monthly_cost <= 10.00:
        monthly_cost += 5.5
    elif monthly_cost <= 30.00:
        monthly_cost += 4.35
    else:
        monthly_cost += 3.85

total_cost = months * monthly_cost

if contract_duration == 'two':
    total_cost *= 0.9625

print(f'{total_cost:.2f} lv.')
