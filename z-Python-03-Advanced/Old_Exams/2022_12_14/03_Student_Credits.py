# https://judge.softuni.org/Contests/Practice/Index/3744#2
# 100/100

def students_credits(*args):
    result = ''
    diyan_courses = {}
    diyan_credits = 0
    for arg in args:
        course_name, course_credit, max_points, diyan_course_points = arg.split('-')
        course_credit = int(course_credit)
        max_points = int(max_points)
        diyan_course_points = int(diyan_course_points)

        course_ratio = diyan_course_points / max_points
        diyan_course_credit = course_credit * course_ratio

        diyan_courses[course_name] = diyan_course_credit
        diyan_credits += diyan_course_credit

    if diyan_credits >= 240:
        result += f'Diyan gets a diploma with {diyan_credits:.1f} credits.\n'
    else:
        credits_shortage = 240 - diyan_credits
        result += f'Diyan needs {credits_shortage:.1f} credits more for a diploma.\n'

    sorted_diyan_courses = dict(sorted(diyan_courses.items(), key = lambda kvp: -kvp[1]))
    for course, credits in sorted_diyan_courses.items():
        result += f'{course} - {credits:.1f}\n'

    return result.strip()


print(
    students_credits(
        "Computer Science-12-300-250",
        "Basic Algebra-15-400-200",
        "Algorithms-25-500-490"
    )
)
print(72 * '*')
print(
    students_credits(
        "Discrete Maths-40-500-450",
        "AI Development-20-400-400",
        "Algorithms Advanced-50-700-630",
        "Python Development-15-200-200",
        "JavaScript Development-12-500-480",
        "C++ Development-30-500-405",
        "Game Engine Development-70-100-70",
        "Mobile Development-25-250-225",
        "QA-20-300-300",
    )
)
print(72 * '*')
print(
    students_credits(
        "Python Development-15-200-200",
        "JavaScript Development-12-500-480",
        "C++ Development-30-500-405",
        "Java Development-10-300-150"
    )
)
