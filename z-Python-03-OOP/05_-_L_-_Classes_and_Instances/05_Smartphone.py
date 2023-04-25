# 100/100

class Smartphone:
    def __init__(self, memory: int):
        self.memory = memory
        self.used_memory = 0
        self.apps = []
        self.is_on = False

    def power(self):
        self.is_on = not self.is_on

    def install(self, app, app_memory):
        if (self.used_memory + app_memory) > self.memory:
            return f"Not enough memory to install {app}"

        if not self.is_on:
            return f"Turn on your phone to install {app}"

        self.used_memory += app_memory
        self.apps.append(app)
        return f"Installing {app}"

    def status(self):
        total_apps_count = len(self.apps)
        memory_left = self.memory - self.used_memory
        return f"Total apps: {total_apps_count}. Memory left: {memory_left}"


smartphone = Smartphone(100)
print(smartphone.install("Facebook", 60))
smartphone.power()
print(smartphone.install("Facebook", 60))
print(smartphone.install("Messenger", 20))
print(smartphone.install("Instagram", 40))
print(smartphone.status())

