# 100/100

def print_rhombus(n):
    def print_line(stars):
        line = (" " * (n - stars)) + ("* " * stars)
        line = line.rstrip()
        return line

    for i in range(1, n * 2):
        stars_cnt = i
        if i > n:
            stars_cnt = 2 * n - i
        line_to_print = print_line(stars_cnt)
        print(line_to_print)


n = int(input())
print_rhombus(n)
