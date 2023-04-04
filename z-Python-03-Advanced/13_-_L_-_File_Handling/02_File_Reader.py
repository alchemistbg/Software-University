# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

# This solution uses file.read() function

# try:
#     f = open('02_File_Reader.txt', 'r')
#     f_content = f.read()
#     numbers = list(map(int, f_content.split()))
#     print(sum(numbers))
#     f.close()
# except FileNotFoundError:
#     print('File not found!')

# This solution uses file.readlines() function. As a result, the solution is shorter.
# try:
#     f = open('02_File_Reader.txt', 'r')
#     numbers = list(map(int, f.readlines()))
#     print(sum(numbers))
#     f.close()
# except FileNotFoundError:
#     print('File not found!')

# This solution iterates through the file using for loop
try:
    f = open('02_File_Reader.txt', 'r')
    numbers_sum = 0
    for line in f:
        number = int(line)
        numbers_sum += number
    print(numbers_sum)
    f.close()
except FileNotFoundError:
    print('File not found!')

