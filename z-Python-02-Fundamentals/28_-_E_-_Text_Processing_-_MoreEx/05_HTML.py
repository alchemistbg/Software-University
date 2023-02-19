# 100/100

def format_tag(tag, tag_content):
    return f'<{tag}>\n    {tag_content}\n</{tag}>\n'


html = ''

title = input()
html += format_tag('h1', title)
content = input()
html += format_tag('article', content)
while True:
    comment = input()
    if comment == 'end of comments':
        break

    html += format_tag('div', comment)

print(html)