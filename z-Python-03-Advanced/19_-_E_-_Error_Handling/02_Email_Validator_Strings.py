class NameTooShortError(Exception):
    pass


class MustContainAtSymbolError(Exception):
    pass


class InvalidDomainError(Exception):
    pass


# This solution uses string operations
while True:
    line = input()
    if line == "End":
        break

    if "@" not in line:
        raise MustContainAtSymbolError("Email must contain @")

    user_name, site = line.split("@")
    site_name, site_domain = site.split('.')
    if len(user_name) < 5:
        raise NameTooShortError("Name must be more than 4 characters")

    if site_domain not in ['com', 'bg', 'org', 'net']:
        raise InvalidDomainError("Domain must be one of the following: .com, .bg, .org, .net")

    print("Email is valid")
