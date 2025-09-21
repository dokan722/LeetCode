from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3110(Problem):
    def test(self) -> bool:
        s = "hello"

        expected = 13

        result = self.scoreOfString(s)

        print(result)

        return expected == result

    def scoreOfString(self, s: str) -> int:
        n = len(s)
        result = 0
        for i in range(1, n):
            result += abs(ord(s[i]) - ord(s[i - 1]))

        return result