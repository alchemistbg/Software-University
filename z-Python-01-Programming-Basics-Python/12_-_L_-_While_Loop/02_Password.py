# 100/100

username = input()
password = input()

text = input()

wrongPass = True
while wrongPass:
    if text == password:
        print(f"Welcome {username}!")
        wrongPass = False
    else:
        text = input()
