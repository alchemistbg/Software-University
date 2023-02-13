# 100/100

exam = {
    'languages': {

    },
    'students': {

    }
}

while True:
    data = input()
    if data == 'exam finished':
        break

    data_tokens = data.split('-')

    if 'banned' not in data_tokens:
        name, lang, score = data_tokens
        score = int(score)

        if lang not in exam['languages'].keys():
            exam['languages'][lang] = 0
        exam['languages'][lang] += 1

        if name not in exam['students'].keys():
            exam['students'][name] = {
                'lang': '',
                'score': 0
            }

        exam['students'][name]['lang'] = lang
        exam['students'][name]['score'] = max(score, exam['students'][name]['score'])
    else:
        name, *args = data_tokens
        exam['students'].pop(name)

print('Results:')
[print(f'{name} | {scores["score"]}') for (name, scores) in exam['students'].items()]
print('Submissions:')
[print(f'{language} - {counts}') for (language, counts) in exam['languages'].items()]
