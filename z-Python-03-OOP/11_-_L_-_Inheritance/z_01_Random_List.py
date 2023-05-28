import random


class RandomList(list):

    def get_random_element(self):
        random_index = random.choice(range(0, len(self)))
        random_element = self.pop(random_index)
        return random_element


rl = RandomList([1, 2, 3, 66])
print(rl.get_random_element())
print(list(rl))
