# 100/100

destination = input()
budget = float(input())
savings = 0

text = input()

toContunue = True
while toContunue:
    if text == "End":
        toContunue = False
    else:
        saving = float(text)
        savings += saving
        #         print(f"saving = {saving}")
        #         print(f"savings = {savings}")
        if savings >= budget:
            print(f"Going to {destination}!")

            destination = input()
            if destination == "End":
                break
            budget = float(input())
            savings = 0
            saving = 0
            text = "0"
        #             print(f"budget = {budget} => saving => {saving} => savings = {savings}")
        else:
            text = input()
