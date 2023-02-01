# 100/100

electrons = int(input())

shell_counter = 1
shells = []

while electrons > 0:
    current_electrons = 2 * (shell_counter ** 2)

    if electrons < current_electrons:
        current_electrons = electrons

    shells.append(current_electrons)
    electrons -= current_electrons

    shell_counter += 1

print(shells)
