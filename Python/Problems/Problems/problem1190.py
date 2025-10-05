import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1190(Problem):
    def test(self) -> bool:
        s = "(ed(et(oc))el)"

        expected = "leetcode"

        result = self.reverseParentheses(s)

        print(result)

        return expected == result

    def reverseParentheses(self, s: str) -> str:
        n = len(s)
        strings = []
        id = 0
        for i in range(n):
            if s[i] == '(':
                strings.append(s[id:i])
                strings.append('(')
                id = i + 1
            elif s[i] == ')':
                reversed = s[id:i][::-1]
                while strings and strings[-1] != '(':
                    reversed += strings.pop()[::-1]
                strings.pop()
                strings.append(reversed)
                id = i + 1

        return ''.join(strings) + (s[id:] if id < n else '')