# 100/100

m_count, n_count = input().split()

m_count = int(m_count)
n_count = int(n_count)

m_set = set()
n_set = set()

for _ in range(m_count):
    el = input()
    m_set.add(el)

for _ in range(n_count):
    el = input()
    n_set.add(el)

diff = m_set & n_set
print('\n'.join(diff))
