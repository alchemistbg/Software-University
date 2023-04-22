# 100/100
# This main file was created to test the objects

from project.task import Task
from project.section import Section

task = Task("Make bed", "27/05/2020")
# print(task.__dict__)
print(task.change_name("Go to University"))
print(task.change_due_date("28.05.2020"))
task.add_comment("Don't forget laptop")
task.add_comment("Second_comment")
print(task.edit_comment(-1, "Don't forget laptop and notebook"))
print(task.details())
section = Section("Daily tasks")
# print(section.__dict__)
print(section.add_task(task))
second_task = Task("Make bed", "27/05/2020")
section.add_task(second_task)
print(section.clean_section())
print(section.complete_task(second_task.name))
print(section.clean_section())
print(section.view_section())
