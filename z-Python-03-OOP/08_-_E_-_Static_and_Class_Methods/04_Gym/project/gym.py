from .customer import Customer
from .equipment import Equipment
from .exercise_plan import ExercisePlan
from .subscription import Subscription
from .trainer import Trainer


class Gym:

    def __init__(self):
        self.customers = []
        self.trainers = []
        self.equipment = []
        self.plans = []
        self.subscriptions = []

    def add_customer(self, customer: Customer):
        customers_ids = [customer.id for customer in self.customers]
        if customer.id not in  customers_ids:
            self.customers.append(customer)

    def add_trainer(self, trainer: Trainer):
        trainers_ids = [trainer.id for trainer in self.trainers]
        if trainer.id not in trainers_ids:
            self.trainers.append(trainer)

    def add_equipment(self, equipment: Equipment):
        equipments_ids = [equipment.id for equipment in self.equipment]
        if equipment.id not in equipments_ids:
            self.equipment.append(equipment)

    def add_plan(self, plan: ExercisePlan):
        plans_ids = [plan.id for plan in self.plans]
        if plan.id not in plans_ids:
            self.plans.append(plan)

    def add_subscription(self, subscription: Subscription):
        subscriptions_ids = [subscription.id for subscription in self.subscriptions]
        if subscription.id not in subscriptions_ids:
            self.subscriptions.append(subscription)

    def subscription_info(self, subscription_id: int):
        subscriptions_ids = [subscription.id for subscription in self.subscriptions]
        info = []
        if subscription_id in subscriptions_ids:
            idx = subscriptions_ids.index(subscription_id)
            subscription = self.subscriptions[idx]
            info.append(str(subscription))
            customer = self.customers[idx]
            info.append(str(customer))
            trainer = self.trainers[idx]
            info.append(str(trainer))
            equipment = self.equipment[idx]
            info.append(str(equipment))
            plan = self.plans[idx]
            info.append(str(plan))

        return "\n".join(info)
