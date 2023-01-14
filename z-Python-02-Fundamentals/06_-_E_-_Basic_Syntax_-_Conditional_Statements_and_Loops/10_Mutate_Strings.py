start_string = list(input())
final_string = list(input())

muted_strings = []

for idx in range(len(start_string)):
    # This works 60/100 - WHY?!?!?!
    # start_string[idx] = final_string[idx]
    # muted_string = "".join(start_string)
    #
    # if muted_string not in muted_strings:
    #     muted_strings.append(muted_string)
    #     print(muted_string)
    #
    # # This works 100/100
    # if start_string[idx] != final_string[idx]:
    #     start_string[idx] = final_string[idx]
    #     print("".join(start_string))

    # This works 100/100
    prev_string = "".join(start_string)
    start_string[idx] = final_string[idx]

    if prev_string != "".join(start_string):
        print("".join(start_string))
