class Connector:

    def connect(self, device) -> str:
        return f'Connected to {device.__class__.__name__}'

    def disconnect(self, device) -> str:
        return f'Disconnected from {device.__class__.__name__}'


class HDMIConnector(Connector):
    pass


class RCAConnector(Connector):
    pass


class EthernetConnector(Connector):
    pass


class PowerConnector(Connector):
    pass


class Television:

    def __init__(self):
        self.hdmi_connector = HDMIConnector()
        self.rca_connector = RCAConnector()
        self.power_connector = PowerConnector()


class DVDPlayer:

    def __init__(self):
        self.hdmi_connector = HDMIConnector()
        self.power_connector = PowerConnector()


class GameConsole:

    def __init__(self):
        self.hdmi_connector = HDMIConnector()
        self.ethernet_connector = EthernetConnector()
        self.power_connector = PowerConnector()


class Router:

    def __init__(self):
        self.ethernet_connector = EthernetConnector()
        self.power_connector = PowerConnector()


tv = Television()
console = GameConsole()
print(tv.hdmi_connector.connect(console))
print(tv.hdmi_connector.disconnect(console))
