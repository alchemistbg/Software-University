from student_report_card import StudentReportCard
# from project.student_report_card import StudentReportCard

import unittest


class StudentReportCardTests(unittest.TestCase):
	def setUp(self):
		self.data = {
			'student_name': 'John Doe',
			'school_year': 1
		}
		self.student_report_card = StudentReportCard(self.data['student_name'], self.data['school_year'])

	def test_student_card_is_initialized_properly(self):
		self.assertEqual(self.data['student_name'], self.student_report_card.student_name)
		self.assertEqual(self.data['school_year'], self.student_report_card.school_year)
		self.assertEqual({}, self.student_report_card.grades_by_subject)

	def test_student_name_setter_raises_error_if_value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.student_report_card.student_name = ""

		self.assertEqual("Student Name cannot be an empty string!", str(ex.exception))

	def test_student_name_setter_if_value_is_valid(self):
		expected = 'John'
		self.student_report_card.student_name = "John"
		self.assertEqual(expected, self.student_report_card.student_name)

	def test_student_year_setter_raises_error_if_value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.student_report_card.school_year = -42

		self.assertEqual("School Year must be between 1 and 12!", str(ex.exception))

		with self.assertRaises(ValueError) as ex:
			self.student_report_card.school_year = 0

		self.assertEqual("School Year must be between 1 and 12!", str(ex.exception))

		with self.assertRaises(ValueError) as ex:
			self.student_report_card.school_year = 42

		self.assertEqual("School Year must be between 1 and 12!", str(ex.exception))
		pass

	def test_student_year_setter_if_value_is_valid(self):
		expected = 1
		self.student_report_card.school_year = 1
		self.assertEqual(expected, self.student_report_card.school_year)

		expected = 12
		self.student_report_card.school_year = 12
		self.assertEqual(expected, self.student_report_card.school_year)

	def test_add_grade(self):
		subject = 'Math'
		grade = 4.5
		self.student_report_card.add_grade(subject, grade)
		self.assertEqual({'Math': [4.5]}, self.student_report_card.grades_by_subject)
		self.assertEqual([grade], self.student_report_card.grades_by_subject[subject])

	def test_average_grade_by_subject(self):
		self.student_report_card.add_grade('Math', 4)
		self.student_report_card.add_grade('Math', 6)

		actual = self.student_report_card.average_grade_by_subject()

		self.assertEqual('Math: 5.00', actual)

	def test_average_grade_for_all_subjects(self):
		self.student_report_card.add_grade('Math', 4)
		self.student_report_card.add_grade('Math', 6)
		expected = f"Average Grade: 5.00"

		actual = self.student_report_card.average_grade_for_all_subjects()
		self.assertEqual(expected, actual)

	def test_repr(self):
		self.student_report_card.add_grade('Math', 4)
		self.student_report_card.add_grade('Math', 6)
		expected = f"Name: {self.data['student_name']}\n" \
				   f"Year: {self.data['school_year']}\n" \
				   f"----------\n" \
				   f"Math: 5.00\n" \
				   f"----------\n" \
				   f"Average Grade: 5.00"
		actual = str(self.student_report_card)
		self.assertEqual(expected, actual)


if __name__ == "__main__":
	unittest.main()
