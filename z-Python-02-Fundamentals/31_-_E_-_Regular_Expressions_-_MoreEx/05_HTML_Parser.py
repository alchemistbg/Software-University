# 100/100

import re

title_pattern = r'<title>([\w\s]+)</title>'
content_pattern = r'<body>(.+)</body>'
html_tag_pattern = r'<.*?>'
new_line_pattern = r'\\n'

html = input()

title = re.search(title_pattern, html)
content = re.search(content_pattern, html)
filtered_content = re.sub(html_tag_pattern, '', content.group(1))
filtered_content = re.sub(new_line_pattern, '', filtered_content)

print(f'Title: {title.group(1)}')
print(f'Content: {filtered_content}')
