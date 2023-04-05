# These problems have no tests in the judge system. The solution gives identical results like the tests from
# the description file

# with open('04_File_Delete.txt', 'w') as f:
#     pass

import os

# try:
#     os.remove('04_File_Delete.txt')
#     print('The file has been deleted successfully!s')
# except FileNotFoundError:
#     print('File not found! Probably it has been already deleted!')


# Another version of teh solution using exists function form os.path module
# file_path = '04_File_Delete.txt'
# if os.path.exists(file_path):
#     os.remove(file_path)
#     print('The file has been deleted successfully!s')
# else:
#     print('File not found! Probably it has been already deleted!')
