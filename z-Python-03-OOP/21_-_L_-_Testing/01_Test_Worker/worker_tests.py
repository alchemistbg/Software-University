from worker import Worker

import unittest


class WorkerTests(unittest.TestCase):

	def setUp(self):
		self.worker = Worker('John Doe', 1000, 100)

	def test_if_worker_is_initialized(self):
		self.assertEqual(self.worker.name, 'John Doe')
		self.assertEqual(self.worker.salary, 1000)
		self.assertEqual(self.worker.energy, 100)
		self.assertEqual(self.worker.money, 0)

	def test_if_worker_energy_is_incremented_after_rest_method_is_called(self):
		self.worker.rest()
		expected_result = 101
		self.assertEqual(self.worker.energy, expected_result)

	def test_if_error_is_raised_if_worker_tries_to_work_with_zero_energy(self):
		self.worker.energy = 0
		with self.assertRaises(Exception) as ex:
			self.worker.work()

		self.assertEqual(str(ex.exception), 'Not enough energy.')

	def test_if_error_is_raised_if_worker_tries_to_work_with_negative_energy(self):
		self.worker.energy = -10
		with self.assertRaises(Exception) as ex:
			self.worker.work()
		self.assertEqual(str(ex.exception), 'Not enough energy.')

	def test_if_workers_money_is_increased_correctly_by_salary_after_work_method_is_called(self):
		self.worker.work()
		self.assertEqual(self.worker.money, 1000)

	def test_if_the_workers_energy_is_decreased_after_the_work_method_is_called(self):
		self.worker.work()
		self.assertEqual(self.worker.energy, 99)

	def test_if_the_get_info_returns_proper_string_with_correct_values(self):
		result = self.worker.get_info()
		expected = 'John Doe has saved 0 money.'
		self.assertEqual(result, expected)

if __name__ == "__main__":
	unittest.main()
