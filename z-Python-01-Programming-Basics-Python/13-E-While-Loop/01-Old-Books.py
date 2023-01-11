# 100/100

searchedBook = input()

text = input()
searchAttempts = 0

while text != "No More Books":
    if text == searchedBook:
        print(f"You checked {searchAttempts} books and found it.")
        break
    searchAttempts += 1
    text = input()
else:
    print("The book you search is not here!")
    print(f"You checked {searchAttempts} books.")
