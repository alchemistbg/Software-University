# 100/100

counter = 0

raw_data = []
miner_data = {}

while True:
    data = input()
    if data == "stop":
        break

    raw_data.append(data)

for idx in range(0, len(raw_data), 2):
    resource = raw_data[idx]
    quantity = int(raw_data[idx + 1])
    if not miner_data.get(resource):
        miner_data[resource] = 0

    miner_data[resource] += quantity

[print(f'{r} -> {q}') for r, q in miner_data.items()]