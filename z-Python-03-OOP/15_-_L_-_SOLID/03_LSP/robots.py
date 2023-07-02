from abc import ABC, abstractmethod


class Robot(ABC):

    @abstractmethod
    def get_sensors_count(self):
        pass


class Android(Robot):
    def get_sensors_count(self):
        return 4


class Chappie(Robot):
    def get_sensors_count(self):
        return 6


def count_robot_senzors(robots: list[Robot]):
    for robot in robots:
        print(f"{robot.__class__.__name__} has {robot.get_sensors_count()} sensors")


robots = [Android(), Chappie()]
count_robot_senzors(robots)
