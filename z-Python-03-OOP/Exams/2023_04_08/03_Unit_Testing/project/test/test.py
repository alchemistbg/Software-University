from project.tennis_player import TennisPlayer

from unittest import TestCase, main


class TennisPlayerTests(TestCase):

	def setUp(self):
		self.player1 = TennisPlayer("Grigor 1", 30, 123)
		self.player2 = TennisPlayer("Grigor 2", 30, 150)

	def test_player_is_initialized_correctly(self):
		self.assertEqual("Grigor 1", self.player1.name)
		self.assertEqual(30, self.player1.age)
		self.assertEqual(123, self.player1.points)
		self.assertEqual([], self.player1.wins)

	def test_name_setter_raise_error_if_Value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.player1.name = ''
		self.assertEqual("Name should be more than 2 symbols!", str(ex.exception))

		with self.assertRaises(ValueError) as ex:
			self.player1.name = '1'
		self.assertEqual("Name should be more than 2 symbols!", str(ex.exception))

		with self.assertRaises(ValueError) as ex:
			self.player1.name = '11'
		self.assertEqual("Name should be more than 2 symbols!", str(ex.exception))

	def test_name_setter_if_value_is_valid(self):
		self.player1.name = "Andre"
		self.assertEqual("Andre", self.player1.name)

	def test_age_setter_raise_error_if_value_is_invalid(self):
		with self.assertRaises(ValueError) as ex:
			self.player1.age = 1

		self.assertEqual("Players must be at least 18 years of age!", str(ex.exception))

	def test_add_win_with_duplicated_data(self):
		tournament_name = "Roland-Garros"
		self.player1.wins.append(tournament_name)
		actual = self.player1.add_new_win(tournament_name)
		expected = f"{tournament_name} has been already added to the list of wins!"
		self.assertEqual(expected, actual)

	def test_add_win_with_unique_data(self):
		tournament_name = "Roland-Garros"
		actual = self.player1.add_new_win(tournament_name)
		expected = None
		self.assertEqual(expected, actual)

		is_in_wins = tournament_name in self.player1.wins
		self.assertTrue(is_in_wins)

	def test_lt_when_compared_with_stronger_player(self):
		expected = f'{self.player2.name} is a top seeded player and he/she is better than {self.player1.name}'
		actual = self.player1.__lt__(self.player2)
		self.assertEqual(expected, actual)

	def test_lt_when_compared_with_weaker_player(self):
		expected = f'{self.player2.name} is a better player than {self.player1.name}'
		actual = self.player2.__lt__(self.player1)
		self.assertEqual(expected, actual)

	def test_str(self):
		self.player1.wins = ['Tournament 1', 'Tournament 2']
		expected = f"Tennis Player: Grigor 1\n" \
				   f"Age: 30\n" \
				   f"Points: 123.0\n" \
				   f"Tournaments won: Tournament 1, Tournament 2"
		actual = str(self.player1)
		self.assertEqual(expected, actual)


if __name__ == "__main__":
	main()
