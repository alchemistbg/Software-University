from typing import List
from .customer import Customer
from .equipment import Equipment
from .exercise_plan import ExercisePlan
from .subscription import Subscription
from .trainer import Trainer


class Gym:

    def __init__(self):
        self.customers: List[Customer] = []
        self.trainers: List[Trainer] = []
        self.equipment: [Equipment] = []
        self.plans: List[ExercisePlan] = []
        self.subscriptions: List[Subscription] = []

    def add_customer(self, customer: Customer) -> None:
        # customers_ids = [customer.id for customer in self.customers]
        # if customer.id not in customers_ids:
        #     self.customers.append(customer)
        if customer not in self.customers:
            self.customers.append(customer)

    def add_trainer(self, trainer: Trainer) -> None:
        # trainers_ids = [trainer.id for trainer in self.trainers]
        # if trainer.id not in trainers_ids:
        #     self.trainers.append(trainer)
        if trainer not in self.trainers:
            self.trainers.append(trainer)

    def add_equipment(self, equipment: Equipment) -> None:
        # equipments_ids = [equipment.id for equipment in self.equipment]
        # if equipment.id not in equipments_ids:
        #     self.equipment.append(equipment)
        if equipment not in self.equipment:
            self.equipment.append(equipment)

    def add_plan(self, plan: ExercisePlan) -> None:
        # plans_ids = [plan.id for plan in self.plans]
        # if plan.id not in plans_ids:
        #     self.plans.append(plan)
        if plan not in self.plans:
            self.plans.append(plan)

    def add_subscription(self, subscription: Subscription) -> None:
        # subscriptions_ids = [subscription.id for subscription in self.subscriptions]
        # if subscription.id not in subscriptions_ids:
        #     self.subscriptions.append(subscription)
        if subscription not in self.subscriptions:
            self.subscriptions.append(subscription)

    def subscription_info(self, subscription_id: int):
        subscriptions_ids = [subscription.id for subscription in self.subscriptions]
        info = []

        # if subscription_id in subscriptions_ids:
        #     idx = subscriptions_ids.index(subscription_id)
        #     subscription = self.subscriptions[idx]
        #     info.append(str(subscription))
        #     customer = self.customers[idx]
        #     info.append(str(customer))
        #     trainer = self.trainers[idx]
        #     info.append(str(trainer))
        #     equipment = self.equipment[idx]
        #     info.append(str(equipment))
        #     plan = self.plans[idx]
        #     info.append(str(plan))

        if subscription_id in subscriptions_ids:
            subscription = self.subscriptions[subscription_id - 1]
            info.append(str(subscription))

            customer = self.customers[subscription.customer_id - 1]
            info.append(str(customer))

            trainer = self.trainers[subscription.trainer_id - 1]
            info.append(str(trainer))

            plan = self.plans[subscription.trainer_id - 1]
            equipment = self.equipment[plan.equipment_id - 1]

            info.append(str(equipment))
            info.append(str(plan))

        return "\n".join(info)
