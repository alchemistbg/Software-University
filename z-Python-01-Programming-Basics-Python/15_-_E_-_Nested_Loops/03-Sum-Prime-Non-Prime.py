# 100/100

import math

text = input()

primesSum = 0
compositesSum = 0

while text != "stop":
    number = int(text)
    if number < 0:
        print("Number is negative.")

    else:
        if (number > 2) and (number % 2 == 0):
            compositesSum += number
        else:
            isPrime = True
            upperBorder = int(math.sqrt(number))
            for i in range(2, upperBorder + 1):
                if i > 2 and i % 2 == 0:
                    continue
                elif number % i == 0:
                    isPrime = False
                    break

            if isPrime:
                primesSum += number
            else:
                compositesSum += number

    #     print(f"Primes: {primesSum}")
    #     print(f"Non Primes: {compositesSum}")
    text = input()

print(f"Sum of all prime numbers is: {primesSum}")
print(f"Sum of all non prime numbers is: {compositesSum}")
