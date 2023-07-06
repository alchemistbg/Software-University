import collections
from collections import abc
collections.MutableMapping = abc.MutableMapping
collections.Container = abc.Container
collections.Callable = abc.Callable

from pyspectator.computer import Computer
computer = Computer()
print(computer.os)
print(computer.python_version)
print(computer.uptime)
print(computer.processor.name)
from pyspectator.processor import Cpu
from time import sleep
cpu = Cpu(monitoring_latency=1)
with cpu:
    for _ in range(8):
       cpu.load
       sleep(1.1)

# import psutil
# print(psutil.disk_partitions())
