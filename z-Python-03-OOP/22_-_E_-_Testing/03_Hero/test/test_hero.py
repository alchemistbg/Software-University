from project.hero import Hero

import unittest


class HeroTests(unittest.TestCase):
	def setUp(self):
		self.hero_values = {
			'username': 'Deku',
			'health': 100,
			'damage': 25,
			'level': 1,
		}
		self.enemy_values = {
			'username': 'Goku',
			'health': 100,
			'damage': 25,
			'level': 1,
		}
		self.hero = Hero(self.hero_values['username'], self.hero_values['level'], self.hero_values['health'], self.hero_values['damage'])
		self.enemy = Hero(self.enemy_values['username'], self.enemy_values['level'], self.enemy_values['health'], self.enemy_values['damage'])

	def test_hero_is_initialized_correctly(self):
		self.assertEqual(self.hero_values['username'], self.hero.username)
		self.assertEqual(self.hero_values['health'], self.hero.health)
		self.assertEqual(self.hero_values['damage'], self.hero.damage)
		self.assertEqual(self.hero_values['level'], self.hero.level)

	def test_battle_raise_error_if_enemy_is_the_same(self):
		self.enemy.username = "Deku"
		with self.assertRaises(Exception) as ex:
			self.hero.battle(self.enemy)

		self.assertEqual("You cannot fight yourself", str(ex.exception))

	def test_battle_raise_error_if_hero_health_is_zero_or_negative(self):
		self.hero.health = 0
		with self.assertRaises(ValueError) as ex:
			self.hero.battle(self.enemy)

		self.assertEqual("Your health is lower than or equal to 0. You need to rest", str(ex.exception))

		self.hero.health = -42
		with self.assertRaises(ValueError) as ex:
			self.hero.battle(self.enemy)

		self.assertEqual("Your health is lower than or equal to 0. You need to rest", str(ex.exception))

	def test_battle_raise_error_if_enemy_health_is_zero_or_negative(self):
		self.enemy.health = 0
		with self.assertRaises(ValueError) as ex:
			self.hero.battle(self.enemy)

		self.assertEqual(f"You cannot fight {self.enemy.username}. He needs to rest", str(ex.exception))

		self.enemy.health = -42
		with self.assertRaises(ValueError) as ex:
			self.hero.battle(self.enemy)

		self.assertEqual(f"You cannot fight {self.enemy.username}. He needs to rest", str(ex.exception))

	def test_battle_if_hero_and_enemy_health_are_calculated_correctly(self):
		self.hero.damage += 5
		hero_damage = self.hero_values['damage'] * self.hero_values['level']
		enemy_damage = self.enemy_values['damage'] * self.enemy_values['level']

		self.hero.battle(self.enemy)

		expected_hero_health = self.hero_values['health'] - enemy_damage
		actual_hero_health = self.hero.health
		self.assertEqual(expected_hero_health, actual_hero_health)

		expected_enemy_health = self.enemy_values['health'] - hero_damage
		actual_enemy_health = self.enemy.health
		self.assertEqual(expected_enemy_health, actual_enemy_health)

	def test_battle_return_draw_if_hero_and_enemy_health_is_zero_or_negative(self):
		self.hero.health = 25
		self.enemy.health = 25

		expected = "Draw"
		actual = self.hero.battle(self.enemy)
		self.assertEqual(expected, actual)

		self.hero.health = 5
		self.enemy.health = 5

		expected = "Draw"
		actual = self.hero.battle(self.enemy)
		self.assertEqual(expected, actual)

	def test_battle_return_win_if_enemy_health_is_zero_or_negative(self):
		self.hero.health = 50
		self.enemy.health = 25
		# After battle
		expected_hero_health = self.hero.health - self.enemy.damage + 5

		expected = "You win"
		actual = self.hero.battle(self.enemy)
		self.assertEqual(expected, actual)

		self.assertEqual(self.hero_values['level'] + 1, self.hero.level)
		self.assertEqual(expected_hero_health, self.hero.health)
		self.assertEqual(self.hero_values['damage'] + 5, self.hero.damage)

	def test_battle_return_loose_if_hero_health_is_zero_or_negative(self):
		self.hero.health = 25
		self.enemy.health = 50
		# After battle
		expected_enemy_health = self.enemy.health - self.hero.damage + 5

		expected = "You lose"
		actual = self.hero.battle(self.enemy)
		self.assertEqual(expected, actual)

		self.assertEqual(self.enemy_values['level'] + 1, self.enemy.level)
		self.assertEqual(expected_enemy_health, self.enemy.health)
		self.assertEqual(self.enemy_values['damage'] + 5, self.enemy.damage)

	def test_str_representation(self):
		expected = f"Hero {self.hero_values['username']}: {self.hero_values['level']} lvl\n" \
				   f"Health: {self.hero_values['health']}\n" \
				   f"Damage: {self.hero_values['damage']}\n"
		actual = str(self.hero)
		self.assertEqual(expected, actual)


if __name__ == '__main__':
	unittest.main()
