class Topic:

    def __init__(self, id: int, topic: str, storage_folder: str):
        self.id = id
        self.topic = topic
        self.storage_folder = storage_folder

    def edit(self, new_topic: str, new_storage_folder: str):
        self.topic = new_topic
        self.storage_folder = new_storage_folder

    @staticmethod
    def get_topic_by_id(topic_id: int, topics: 'Topic'):
        topics_ids = [topic.id for topic in topics]
        if topic_id in topics_ids:
            topic_idx = topics_ids.index(topic_id)
            return topics[topic_idx]

        return None

    def __repr__(self):
        return f"Topic {self.id}: {self.topic} in {self.storage_folder}"
