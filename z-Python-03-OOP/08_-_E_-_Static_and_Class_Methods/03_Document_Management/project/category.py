from typing import List


class Category:

    def __init__(self, id: int, name: str):
        self.id = id
        self.name = name

    def edit(self, new_name: str):
        self.name = new_name

    @staticmethod
    def get_category_by_id(category_id: int, categories: List['Category']):
        categories_ids = [category.id for category in categories]
        if category_id in categories_ids:
            topic_idx = categories_ids.index(category_id)
            return categories[topic_idx]

        return None

    def __repr__(self):
        return f"Category {self.id}: {self.name}"