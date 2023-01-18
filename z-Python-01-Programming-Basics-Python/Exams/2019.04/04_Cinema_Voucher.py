# 100/100

voucher_budget = int(input())

movies_count = 0
purchases_count = 0

while True:
    purchase = input()
    purchase_price = 0
    purchase_type = None

    if purchase == "End":
        break

    if len(purchase) > 8:
        purchase_price = ord(purchase[0]) + ord(purchase[1])
        purchase_type = 'movie'
    else:
        purchase_price = ord(purchase[0])

    if voucher_budget < purchase_price:
        break

    voucher_budget -= purchase_price
    if purchase_type:
        movies_count += 1
    else:
        purchases_count += 1

print(movies_count)
print(purchases_count)
