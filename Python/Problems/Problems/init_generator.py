import os
from os import listdir
import re

problem_numbers = []

for filename in listdir('./'):
    if re.match('problem[0-9]+.py', filename):
        problem_numbers.append(int(filename[7:-3]))
problem_numbers.sort()

lines = ['from Problems.problem import Problem\n']
for num in problem_numbers:
    lines.append('from Problems.problem{0} import Problem{0}\n'.format(num))

lines.append('__all__ = [' + ',\n'.join(['\'Problem' + str(num) + '\'' for num in problem_numbers]) + ']')

with open('__init__.py', 'w') as f:
    f.writelines(lines)