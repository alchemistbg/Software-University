# https://judge.softuni.org/Contests/Practice/Index/3596#2
# 100/100

def forecast(*args):
    data = {}
    for arg in args:
        location, weather = arg
        data[location] = weather

    sorted_data = dict(sorted(data.items(), key = lambda kvp: kvp[0]))

    final_data = {}
    weather_order = ['Sunny', 'Cloudy', 'Rainy']
    for w in weather_order:
        final_data.update({k: v for k, v in sorted_data.items() if v == w})

    result = ''
    for location, weather in final_data.items():
        result += f'{location} - {weather}\n'
    return result

print(forecast(
    ("Sofia", "Sunny"),
    ("London", "Cloudy"),
    ("New York", "Sunny"))
)

print(forecast(
    ("Beijing", "Sunny"),
    ("Hong Kong", "Rainy"),
    ("Tokyo", "Sunny"),
    ("Sofia", "Cloudy"),
    ("Peru", "Sunny"),
    ("Florence", "Cloudy"),
    ("Bourgas", "Sunny"))
)

