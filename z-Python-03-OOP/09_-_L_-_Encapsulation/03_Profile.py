# 100/100

import re

class Profile:

    def __init__(self, username, password):
        self.__username = self.set_username(username)
        self.__password = self.set_password(password)

    def get_username(self):
        return self.__username

    def set_username(self, username):
        if self.__is_username_valid(username):
            return username
        else:
            raise ValueError("The username must be between 5 and 15 characters.")

    def __is_username_valid(self, username):
        return 5 <= len(username) <= 15

    def get_password(self):
        return self.__password

    def set_password(self, password):
        if self.__is_password_valid(password):
            return password
        else:
            raise ValueError("The password must be 8 or more characters with at least 1 digit and 1 uppercase letter.")

    def __is_password_valid(self, password):
        pattern = r"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
        match = re.match(pattern, password)
        if match:
            return True
        return False

    def __str__(self):
        password_mask = "*" * len(self.get_password())
        return f'You have a profile with username: "{self.get_username()}" and password: {password_mask}'


# profile_with_invalid_password = Profile('My_username', 'My-password')
# profile_with_invalid_username = Profile('Too_long_username', 'Any')
correct_profile = Profile("Username", "Passw0rd")
print(correct_profile)
