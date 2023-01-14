# 100/100

string = input().lower()
query_list = ["Sand", "Water", "Fish", "Sun"]

matches = 0

for query in query_list:
    matches += string.count(query.lower())

print(matches)

# Old solution for this problem - almost identical
# string = input().lower()
#
# patterns = ["Sand", "Water", "Fish", "Sun"]
#
# occurences = 0
# for word in patterns:
#     occurences += string.count(word.lower())
#
# print(occurences)
