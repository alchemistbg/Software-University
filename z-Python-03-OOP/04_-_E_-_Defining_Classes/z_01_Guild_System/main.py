# 100/100
# This main file was created to test the objects

from project.player import Player
from project.guild import Guild

if __name__ == "__main__":
    player = Player("George", 50, 100)
    print(player.add_skill("Shield Break", 20))
    print(player.player_info())
    guild = Guild("UGT")
    print(guild.assign_player(player))
    print(guild.kick_player("Stefcho"))

    gancho = Player("Gancho", 50, 100)
    losers = Guild("Losers")
    print(losers.assign_player(gancho))
    stefcho = Player("Stefcho", 100, 100)
    print(losers.assign_player(stefcho))
    print(losers.kick_player("Stefcho"))
    # print(stefcho.player_info())

    print(guild.guild_info())
