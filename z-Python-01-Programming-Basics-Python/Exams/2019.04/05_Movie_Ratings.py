# 100/100

import math

movies = int(input())

max_rating_name = None
max_rating_value = math.inf * -1

min_rating_name = None
min_rating_value = math.inf

avrg_rating = 0

for movie in range(movies):
    movie_name = input()
    movie_rating = float(input())

    avrg_rating += movie_rating

    if max_rating_value < movie_rating:
        max_rating_value = movie_rating
        max_rating_name = movie_name
    elif min_rating_value > movie_rating:
        min_rating_value = movie_rating
        min_rating_name = movie_name

avrg_rating /= movies

print(f'{max_rating_name} is with highest rating: {max_rating_value:.1f}')
print(f'{min_rating_name} is with lowest rating: {min_rating_value:.1f}')
print(f'Average rating: {avrg_rating:.1f}')