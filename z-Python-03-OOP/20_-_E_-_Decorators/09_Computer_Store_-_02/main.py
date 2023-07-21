# from project.computer_types.computer import Computer
# from project.computer_types.desktop_computer import DesktopComputer
# from project.computer_types.laptop import Laptop
from project.computer_store_app import ComputerStoreApp

# pc = DesktopComputer("Apple", "MacBook")
# pc.configure_computer("AMD Ryzen 7 5700G", 64)
# print(pc)


computer_store = ComputerStoreApp()

print(computer_store.build_computer("Laptop", "Apple", "Macbook", "Apple M1 Pro", 64))
print(computer_store.sell_computer(10000, "Apple M1 Pro", 32))
# print(computer_store.sell_computer(10000, "Apple M1 Pro", 32))

print(computer_store.build_computer("Desktop Computer", "Lenovo", "Legion", "AMD Ryzen 7 5700G", 128))
print(computer_store.sell_computer(5000, "AMD Ryzen 7 5700G", 32))

print(computer_store.profits)
