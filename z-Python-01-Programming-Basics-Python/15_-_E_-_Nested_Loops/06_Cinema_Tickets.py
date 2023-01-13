# 100/100

movie = input()

standardTickets = 0
studentTickets = 0
kidTickets = 0

movieTickets = 0

totalTickets = 0

while movie != "Finish":
    movieCapacity = int(input())
    for i in range(movieCapacity):
        ticket = input()
        if ticket == "standard":
            standardTickets += 1
        elif ticket == "student":
            studentTickets += 1
        elif ticket == "kid":
            kidTickets += 1
        elif ticket == "End":
            break

        movieTickets += 1
        totalTickets += 1

    movieCapacity = movieTickets / movieCapacity * 100
    print(f"{movie} - {movieCapacity:.2f}% full.")
    movieTickets = 0
    movie = input()

standardPercentage = standardTickets / totalTickets * 100
studentPercentage = studentTickets / totalTickets * 100
kidPercentage = kidTickets / totalTickets * 100

print(f"Total tickets: {totalTickets}")
print(f"{studentPercentage:.2f}% student tickets.")
print(f"{standardPercentage:.2f}% standard tickets.")
print(f"{kidPercentage:.2f}% kids tickets.")
