# from player import Player


class Guild:
    def __init__(self, name: str):
        self.name = name
        self.players = []

    def __get_players_names(self):
        return [player.name for player in self.players]

    def assign_player(self, player_to_add):
        if player_to_add.guild != "Unaffiliated" and player_to_add.guild != self.name:
            return f"Player {player_to_add.name} is in another guild."

        # players_names = self.__get_players_names()
        if player_to_add.name in self.__get_players_names():
            return f"Player {player_to_add.name} is already in the guild."

        player_to_add.guild = self.name
        self.players.append(player_to_add)
        return f"Welcome player {player_to_add.name} to the guild {player_to_add.guild}"

    def kick_player(self, player_to_kick: str):
        if player_to_kick not in self.__get_players_names():
            return f"Player {player_to_kick} is not in the guild."

        player_to_kick_idx = self.__get_players_names().index(player_to_kick)

        kicked_player = self.players.pop(player_to_kick_idx)
        kicked_player.guild = "Unaffiliated"
        return f"Player {player_to_kick} has been removed from the guild."

    def guild_info(self):
        g_info = [f"Guild: {self.name}"]
        players_info = [f'{player.player_info()}\n' for player in self.players]
        return "\n".join(g_info + players_info)
