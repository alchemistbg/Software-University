# I cannot test this solution, because the problem is removed from the judge system

#  My solution
# start = int(input())
# end = int(input()) + 1
# divisors = [div for div in range(2, 11)]
# result = list(set([num for num in range(start, end) for div in range(2, 11) if num % div == 0]))
# print(result)

# Teacher's solution
start = int(input())
end = int(input()) + 1
filtered = [num for num in range(start, end) if any([num % div == 0 for div in range(2, 11)])]
print(filtered)