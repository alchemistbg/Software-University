import calendar


class DVD:
    _months = {}

    def __init__(self, name: str, id: int, creation_year: int, creation_month: str, age_restriction: int):
        self.name = name
        self.id = id
        self.creation_year = creation_year
        self.creation_month = creation_month
        self.age_restriction = age_restriction
        self.is_rented = False

    def __repr__(self):
        status = "rented" if self.is_rented else "not rented"
        return f"{self.id}: {self.name} ({self.creation_month} {self.creation_year}) " \
               f"has age restriction {self.age_restriction}. Status: {status}"

    @classmethod
    def from_date(cls, id: int, name: str, date: str, age_restriction: int) -> 'DVD':
        day, month, year = map(int, date.split('.'))
        month = calendar.month_name[month]
        return cls(name, id, year, month, age_restriction)
