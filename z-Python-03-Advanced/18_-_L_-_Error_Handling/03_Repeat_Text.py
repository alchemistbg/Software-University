text = input()
try:
    t = int(input())
    print(text * t)
except ValueError:
    print("Variable times must be an integer")