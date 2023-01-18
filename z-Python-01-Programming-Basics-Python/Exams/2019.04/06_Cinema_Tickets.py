# 100/100

total_tickets = 0
student_tickets = 0
standard_tickets = 0
kids_tickets = 0

while True:
    line = input()

    if line == "Finish":
        break

    movie_name = line
    movie_total_capacity = int(input())
    movie_sold_tickets = 0
    for _ in range(movie_total_capacity):
        ticket_type = input()
        if ticket_type == 'End':
            break
        movie_sold_tickets += 1
        if ticket_type == "student":
            student_tickets += 1
        elif ticket_type == "standard":
            standard_tickets += 1
        else:
            kids_tickets += 1
    movie_used_capacity = movie_sold_tickets / movie_total_capacity * 100
    total_tickets += movie_sold_tickets

    print(f"{movie_name} - {movie_used_capacity:.2f}% full.")

student_tickets_percentage = student_tickets / total_tickets * 100
standard_tickets_percentage = standard_tickets / total_tickets * 100
kids_tickets_percentage = kids_tickets / total_tickets * 100


print(f"Total tickets: {total_tickets}")
print(f"{student_tickets_percentage:.2f}% student tickets.")
print(f"{standard_tickets_percentage:.2f}% standard tickets.")
print(f"{kids_tickets_percentage:.2f}% kids tickets.")
