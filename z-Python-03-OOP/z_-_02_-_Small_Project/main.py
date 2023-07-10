import requests

URL = "https://api.instantwebtools.net/v1/passenger?page={page}&size={size}"


def list_all_passengers(page_num, page_size):
	total_pages = None

	while True:
		print(f'Now requesting page {page_num} of {total_pages}:')
		if page_num == total_pages:
			break
		url = URL.format(page = page_num, size = page_size)
		response = requests.get(url)
		data = response.json()
		total_pages = data['totalPages']
		for line in data['data']:
			yield line
		page_num += 1
		print(79 * "*")


passengers = list_all_passengers(page_num = 0, page_size = 20)
for p in passengers:
	print(p['name'])
