# 100/100

path = input()
path_elements = path.split('\\')
filename_elements = path_elements[-1]
filename, fileext = filename_elements.split('.')
print(f'File name: {filename}')
print(f'File extension: {fileext}')