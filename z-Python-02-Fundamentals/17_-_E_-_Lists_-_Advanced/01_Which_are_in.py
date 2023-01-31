# 100/100

def check_query(query, words):
    # for word in words:
    #     if query in word:
    #         return True
    return [True for word in words if query in word]


queries = input().split(', ')
# words = input().split(', ') # This is necessary for the next two solutions

# This approach uses list comprehension
# matched_queries = [query for query in queries if check_query(query, words)]

# This approach uses filter and lambda function
# matched_queries = list(filter(lambda query: check_query(query, words), queries))

words = input()
matched_queries = [query for query in queries if query in words]

print(matched_queries)

