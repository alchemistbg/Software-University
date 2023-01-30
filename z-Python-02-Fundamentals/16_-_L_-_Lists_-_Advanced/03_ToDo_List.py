# 100/100

def add_todo(todos, todo, importance):
    todos.pop(importance)
    todos.insert(importance, todo)
    # todos[importance] = todo - another way to do that
    return todos


def filter_todos(todos):
    result = filter(None, todos)
    result = list(result)
    return result


string = input()
todos = list([''] * 10)

while string != 'End':
    importance, todo = string.split('-')
    importance = int(importance) - 1
    add_todo(todos, todo, importance)
    string = input()

todos = filter_todos(todos)
print(todos)