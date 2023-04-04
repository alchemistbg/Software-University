# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

# try:
#     f = open('01_File_Opener.txt')
#     print('File found')
# except FileNotFoundError:
#     print('File not found')


# Another implementation
import os.path

if os.path.exists('02_File_Reader3.txt'):
    print('File exists')
else:
    print('File not found')
