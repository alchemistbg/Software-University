from typing import List


class Section:
    def __init__(self, name: str):
        self.name = name
        self.tasks = []

    def __get_tasks_names(self) -> List:
        return [task.name for task in self.tasks]

    def add_task(self, new_task) -> str:
        if new_task.name in self.__get_tasks_names():
            return f"Task is already in the section {self.name}"

        self.tasks.append(new_task)
        return f"Task {new_task.details()} is added to the section"

    def complete_task(self, task_name: str) -> str:
        task_names = self.__get_tasks_names()
        if task_name not in task_names:
            return f"Could not find task with the name {task_name}"

        task_idx = task_names.index(task_name)
        self.tasks[task_idx].completed = True
        return f"Completed task {task_name}"

    def clean_section(self) -> str:
        uncompleted_tasks = [task for task in self.tasks if not task.completed]
        cleared_tasks_num = len(self.tasks) - len(uncompleted_tasks)
        self.tasks = uncompleted_tasks
        return f"Cleared {cleared_tasks_num} tasks."

    def view_section(self):
        section_info = [f"Section {self.name}: "]
        tasks_info = [task.details() for task in self.tasks]
        return "\n".join(section_info + tasks_info)