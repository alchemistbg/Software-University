# 100/100

city = input()
sales = float(input())

cities = "Sofia, Plovdiv, Varna"

if city not in cities or sales < 0:
    print("error")
else:
    commission = 0
    if city == "Sofia":
        if sales >= 0 and sales <= 500:
            commission = sales * 0.05
        elif sales > 500 and sales <= 1000:
            commission = sales * 0.07
        elif sales > 1000 and sales <= 10000:
            commission = sales * 0.08
        elif sales > 10000:
            commission = sales * 0.12
        else:
            print("error")
    elif city == "Varna":
        if sales >= 0 and sales <= 500:
            commission = sales * 0.045
        elif sales > 500 and sales <= 1000:
            commission = sales * 0.075
        elif sales > 1000 and sales <= 10000:
            commission = sales * 0.10
        elif sales > 10000:
            commission = sales * 0.13
        else:
            print("error")
    elif city == "Plovdiv":
        if sales >= 0 and sales <= 500:
            commission = sales * 0.055
        elif sales > 500 and sales <= 1000:
            commission = sales * 0.08
        elif sales > 1000 and sales <= 10000:
            commission = sales * 0.12
        elif sales > 10000:
            commission = sales * 0.145
        else:
            print("error")
    print(f"{commission:.2f}")
