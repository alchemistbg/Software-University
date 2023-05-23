class Player:

    def __init__(self, name: str, sprint: int, dribble: int, passing: int, shooting: int):
        self.__name = name
        self.__sprint = sprint
        self.__dribble = dribble
        self.__passing = passing
        self.__shooting = shooting

    @property
    def name(self):
        return self.__name

    @name.setter
    def name(self, value):
        self.__name = value

    def __str__(self):
        player_info = ""
        player_info += f"Player: {self.name}\n"
        player_info += f"Sprint: {self.__sprint}\n"
        player_info += f"Dribble: {self.__dribble}\n"
        player_info += f"Passing: {self.__passing}\n"
        player_info += f"Shooting: {self.__shooting}\n"
        return player_info
