# 100/100

class Class:
    __students_count = 22

    def __init__(self, name: str):
        self.name = name
        self.students = []
        self.grades = []

    def add_student(self, name: str, grade: float):
        current_student_count = self.__get_current_student_count()
        if current_student_count < Class.__students_count:
            self.students.append(name)
            self.grades.append(grade)

    def get_average_grade(self):
        grades_sum = sum(self.grades)
        current_student_count = self.__get_current_student_count()
        average = grades_sum / current_student_count
        return average

    def __get_current_student_count(self):
        return len(self.students)

    def __repr__(self):
        # return f'The students in {self.name}: {", ".join(self.students)}. Average grade: {round(self.get_average_grade(), 2)}'
        return f'The students in {self.name}: {", ".join(self.students)}. Average grade: {self.get_average_grade():.2f}'


a_class = Class("11B")
a_class.add_student("Peter", 4.75)
a_class.add_student("George", 5.21)
a_class.add_student("Amy", 3.50)
print(a_class.get_average_grade())
print(a_class)
