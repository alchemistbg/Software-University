from project.student import Student

import unittest


class StudentTests(unittest.TestCase):
	def setUp(self):
		self.courses = {
			'Course 1': ['Course 1: Note 1', 'Course 1: Note 2']
		}
		self.student = Student('Unufri', self.courses.copy())

	def test_student_initialize_correctly_with_empty_courses(self):
		student = Student('Unufri')
		self.assertEqual('Unufri', student.name)
		self.assertEqual({}, student.courses)

	def test_student_initialize_correctly_with_courses(self):
		self.assertEqual('Unufri', self.student.name)
		self.assertEqual(self.courses, self.student.courses)

	def test_enroll_update_notes_if_course_in_courses(self):
		course = 'Course 1'
		notes = 'Course 1: Note 3'
		expected = "Course already added. Notes have been updated."
		actual = self.student.enroll(course, notes)
		self.assertEqual(expected, actual)

	def test_enroll_add_course_if_add_course_notes_is_not_passed(self):
		course = 'Course 2'
		notes = 'Course 2: Note 1'
		expected = "Course and course notes have been added."
		actual = self.student.enroll(course, notes)
		self.assertEqual(expected, actual)

	def test_enroll_add_course_if_add_course_notes_is_passed(self):
		course = 'Course 2'
		notes = 'Course 2: Note 1'
		self.courses[course] = [notes]

		expected = "Course and course notes have been added."
		actual = self.student.enroll(course, [notes], add_course_notes = 'Y')

		self.assertEqual(expected, actual)
		self.assertEqual(self.courses, self.student.courses)

	def test_enroll_add_course_if_add_course_notes_is_set_to_n(self):
		course = 'Course 2'
		notes = 'Course 2: Note 1'

		expected = "Course has been added."
		actual = self.student.enroll(course, notes, add_course_notes = 'n')

		self.assertEqual(expected, actual)
		self.assertEqual([], self.student.courses[course])

	def test_add_notes_raises_exception_if_course_name_is_missing(self):
		course = 'Course 2'
		notes = ['Course 2: Note 1', 'Course 2: Note 2']
		with self.assertRaises(Exception) as ex:
			self.student.add_notes(course, notes)

		self.assertEqual("Cannot add notes. Course not found.", str(ex.exception))

	def test_add_notes_with_valid_data(self):
		course = 'Course 1'
		notes = 'Course 1: Note 3'
		self.student.add_notes(course, notes)
		self.assertEqual(self.courses[course], self.student.courses[course])

	def test_leave_course_raises_exception_if_course_name_is_missing(self):
		course = 'Course 2'
		with self.assertRaises(Exception) as ex:
			self.student.leave_course(course)

		self.assertEqual("Cannot remove course. Course not found.", str(ex.exception))

	def test_leave_course_with_valid_data(self):
		course = 'Course 1'
		self.student.leave_course(course)
		self.assertEqual({}, self.student.courses)


if __name__ == "__main__":
	unittest.main()
