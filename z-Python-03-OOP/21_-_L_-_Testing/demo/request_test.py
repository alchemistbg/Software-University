import unittest
from unittest import mock
import request


class RequestTetss(unittest.TestCase):
	def test_my_daily_task(self):
		mock_value = {'completed': False, 'id': 1, 'title': 'delectus aut autem', 'userId': 1}
		with unittest.mock.patch('request.get_task', return_value = mock_value):
			daily_task = request.my_daily_todo()
		self.assertEqual(daily_task, [{
			"userId":    1,
			"id": 1,
			"title": "delectus aut autem",
			"completed": False,
		}])


if __name__ == "__main__":
	unittest.main()
