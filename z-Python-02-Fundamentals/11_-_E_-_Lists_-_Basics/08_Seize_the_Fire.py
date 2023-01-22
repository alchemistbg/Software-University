# 100/100
# This solution is very big. Maybe it could be reduced!

cells = input().split('#')
water = int(input())

put_out_cells = []

effort = 0
total_fire = 0

for cell in cells:
    cell_type, cell_value = cell.split(' = ')
    cell_value = int(cell_value)
    is_cell_valid = (
        (cell_type == 'Low' and 0 < cell_value < 51) or
        (cell_type == 'Medium' and 50 < cell_value < 81) or
        (cell_type == 'High' and 80 < cell_value < 126)
    )

    if is_cell_valid and cell_value <= water:
        put_out_cells.append(str(cell_value))
        water -= cell_value
        total_fire += cell_value
        effort += 0.25 * cell_value

print('Cells:')
for c in put_out_cells:
    print(f' - {c}')
print(f'Effort: {effort:.2f}')
print(f'Total Fire: {total_fire}')