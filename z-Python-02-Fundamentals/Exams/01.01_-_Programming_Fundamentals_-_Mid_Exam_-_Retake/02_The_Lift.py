people = int(input())
empty_lifts = list(map(int, input().split()))
full_lifts = empty_lifts[:]
empty_lifts.reverse()

lift_idx = 0
while empty_lifts:
    current_lift = empty_lifts.pop()
    current_people = 4 - current_lift
    people -= current_people
    if people < 0:
        full_lifts[lift_idx] = 4 + people
        break
    elif people == 0:
        full_lifts[lift_idx] = current_lift + current_people
        break
    else:
        full_lifts[lift_idx] = 4
        lift_idx += 1

if people < 0:
    print('The lift has empty spots!')
elif people > 0:
    print(f"There isn't enough space! {people} people in a queue!")
print(' '.join(map(str, full_lifts)))
