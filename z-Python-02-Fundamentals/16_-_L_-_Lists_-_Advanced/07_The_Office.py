# 100/100

happiness = [int(x) for x in input().split()]
factor = int(input())

half = len(happiness) // 2

improved_happiness = list(map(lambda n: n * factor, happiness))
mean_happiness = sum(improved_happiness) // len(improved_happiness)
filtered_happiness = list(filter(lambda n: n > mean_happiness, improved_happiness))

total_count = len(happiness)
happy_count = len(filtered_happiness)

if happy_count >= half:
    print(f'Score: {happy_count}/{total_count}. Employees are happy!')
else:
    print(f'Score: {happy_count}/{total_count}. Employees are not happy!')
