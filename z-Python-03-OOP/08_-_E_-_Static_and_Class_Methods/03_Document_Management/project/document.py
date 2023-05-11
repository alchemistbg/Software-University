from typing import List
from .category import Category
from .topic import Topic


class Document:

    def __init__(self, id: int, category_id: int, topic_id: int, file_name: str):
        self.id = id
        self.category_id = category_id
        self.topic_id = topic_id
        self.file_name = file_name
        self.tags: List[str] = []

    @classmethod
    def from_instances(cls, id: int, category: Category, topic: Topic, file_name: str):
        category_id = category.id
        topic_id = topic.id
        return cls(id, category_id, topic_id, file_name)

    def add_tag(self, tag_content: str):
        if tag_content not in self.tags:
            self.tags.append(tag_content)

    def remove_tag(self, tag_content: str):
        if tag_content in self.tags:
            self.tags.remove(tag_content)

    def edit(self, new_file_name: str):
        self.file_name = new_file_name

    @staticmethod
    def get_document_by_id(document_id: int, documents: List['Documents']):
        documents_ids = [document.id for document in documents]
        if document_id in documents_ids:
            document_idx = documents_ids.index(document_id)
            return documents[document_idx]

    def __repr__(self):
        tags = ", ".join(self.tags)
        return f"Document {self.id}: {self.file_name}; category {self.category_id}, " \
               f"topic {self.topic_id}, tags: {tags}"
