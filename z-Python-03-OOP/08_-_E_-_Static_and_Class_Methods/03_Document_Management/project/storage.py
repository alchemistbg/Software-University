from typing import List
from .category import Category
from .topic import Topic
from .document import Document


class Storage:

    def __init__(self):
        self.categories: List[Category] = []
        self.topics: List[Topic] = []
        self.documents: List[Document] = []

    def add_topic(self, topic: Topic):
        if topic not in self.topics:
            self.topics.append(topic)

    def edit_topic(self, topic_id: int, new_topic: str, new_storage_folder: str):
        topic = Topic.get_topic_by_id(topic_id, self.topics)
        if topic:
            topic.edit(new_topic, new_storage_folder)

    def delete_topic(self, topic_id: int):
        topic = Topic.get_topic_by_id(topic_id, self.topics)
        if topic:
            self.topics.remove(topic)

    def add_category(self, category: Category):
        if category not in self.categories:
            self.categories.append(category)

    def edit_category(self, category_id: int, new_name: str):
        category = Category.get_category_by_id(category_id, self.categories)
        if category:
            category.edit(new_name)

    def delete_category(self, category_id):
        category = Category.get_category_by_id(category_id, self.categories)
        if category:
            self.categories.remove(category)

    def add_document(self, document: Document):
        if document not in self.documents:
            self.documents.append(document)

    def get_document(self, document_id: int):
        document = Document.get_document_by_id(document_id, self.documents)
        if document:
            return document

    def edit_document(self, document_id: int, new_file_name: str):
        document = Document.get_document_by_id(document_id, self.documents)
        if document:
            document.edit(new_file_name)

    def delete_document(self, document_id):
        document = Document.get_document_by_id(document_id, self.documents)
        if document:
            self.documents.remove(document)

    def __repr__(self):
        docs = [str(document) for document in self.documents]
        return "\n".join(docs)
