from typing import List, Union
from .user import User
from .library import Library


class Registration:

    def __init__(self):
        pass

    def __get_users_ids(self, library: Library) -> List[int]:
        return [user.user_id for user in library.user_records]

    def add_user(self, user: User, library: Library) -> Union[None, str]:
        users_ids = self.__get_users_ids(library)

        if user.user_id in users_ids:
            return f"User with id = {user.user_id} already registered in the library!"

        library.user_records.append(user)

    def remove_user(self, user: User, library: Library) -> Union[None, str]:
        users_ids = self.__get_users_ids(library)

        if user.user_id not in users_ids:
            return f"We could not find such user to remove!"

        library.user_records.remove(user)

    def change_username(self, user_id: int, new_username: str, library: Library):
        users_ids = self.__get_users_ids(library)

        if user_id not in users_ids:
            return f"There is no user with id = {user_id}!"

        user_id_idx = users_ids.index(user_id)
        if library.user_records[user_id_idx].username == new_username:
            return "Please check again the provided username - it should be different than the username used so far!"

        library.user_records[user_id_idx].username = new_username
        return f"Username successfully changed to: {new_username} for user id: {user_id}"
