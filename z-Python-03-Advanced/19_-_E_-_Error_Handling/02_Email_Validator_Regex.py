import re


class NameTooShortError(Exception):
    pass


class MustContainAtSymbolError(Exception):
    pass


class InvalidDomainError(Exception):
    pass


# This solution uses regex
regex = r"(?P<name>.*)(?P<at_sign>@)(?P<provider>.*)\.(?P<domain>.*)"
while True:
    line = input()
    if line == "End":
        break

    matches = re.finditer(regex, line)
    matches_list = list(matches)
    if len(matches_list) == 0:
        raise MustContainAtSymbolError("Email must contain @")
    else:
        for match in matches_list:
            if len(match.group("name")) < 5:
                raise NameTooShortError("Name must be more than 4 characters")
            elif len(match.group("domain")) == 0:
                raise InvalidDomainError("Domain must be one of the following: .com, .bg, .org, .net")
            else:
                print("Email is valid")
