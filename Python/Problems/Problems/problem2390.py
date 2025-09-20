from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2390(Problem):
    def test(self) -> bool:
        s = "leet**cod*e"

        expected = "lecoe"

        result = self.removeStars(s)

        print(result)

        return expected == result

    def removeStars(self, s: str) -> str:
        stack = []
        for c in s:
            if c == '*':
                stack.pop()
            else:
                stack.append(c)

        return ''.join(stack)