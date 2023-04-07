import os


def create_some_files():
    # This piece of the code creates some files needed for the current solution
    files = ['Index.html', 'About.html', 'Blog.html', 'Index.css', 'Index.js', 'Jquery.js', 'Data.txt', 'Log.txt']
    for file in files:
        with open(f'04_Directory_Traversal_{file}', 'a') as f:
            pass


def dir_entry_to_str(de):
    de_str = str(de)
    de_str = de_str[11:-2]
    return de_str


def get_file_ext(file_name: str):
    idx_fo_split = file_name.index('.')
    return file_name[idx_fo_split:]


def process_raw_tree(raw_tree):
    tree = {}

    for leaf in raw_tree:
        file_name = dir_entry_to_str(leaf)
        file_ext = get_file_ext(file_name)

        if file_ext not in tree.keys():
            tree[file_ext] = []
        tree[file_ext].append(file_name)

    sorted_tree = dict(sorted(tree.items(), key=lambda kvp: kvp[0]))
    return sorted_tree


def file_tree_to_string(file_tree):
    tree_string = ''
    for key, value in file_tree.items():
        ext_string = f'{key}\n- - -'
        f_string = '\n- - -'.join(value)
        tree_string += ext_string + f_string + '\n'
    return tree_string.strip()


def get_output_path():
    current_user_path = os.path.expanduser('~')
    full_output_path = os.path.join(current_user_path, 'Desktop', 'report.txt')
    return full_output_path


def write_tree_to_file(tree, full_output_path):
    with open(full_output_path,'a+') as f:
        f.write(tree)


create_some_files()

raw_tree = os.scandir()
final_tree = process_raw_tree(raw_tree)
string_tree = file_tree_to_string(final_tree)
output_path = get_output_path()
write_tree_to_file(string_tree, output_path)
