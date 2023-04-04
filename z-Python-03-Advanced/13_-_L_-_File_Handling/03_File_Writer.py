# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

# f = open('03_File_Writer_1.txt', 'w')
# f.write('I just created my first file!')
# f.close()

with open('03_File_Writer_2.txt', 'w') as f:
    f.write('I just created my first file using with statement!')
