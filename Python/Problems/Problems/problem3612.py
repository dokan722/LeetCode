from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3612(Problem):
    def test(self) -> bool:
        s = "a#b%*"

        expected = "ba"

        result = self.processStr(s)

        print(result)

        return expected == result

    def processStr(self, s: str) -> str:
        result = []
        for c in s:
            if c == '*':
                if len(result) > 0:
                    result.pop()
            elif c == '#':
                result += result
            elif c == '%':
                result = result[::-1]
            else:
                result.append(c)

        return ''.join(result)