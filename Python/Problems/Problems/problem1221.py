from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem1221(Problem):
    def test(self) -> bool:
        s = "RLRRLLRLRL"

        expected = 4

        result = self.balancedStringSplit(s)

        print(result)

        return result == expected

    def balancedStringSplit(self, s: str) -> int:
        ls = 0
        rs = 0
        result = 0
        for c in s:
            if c == 'L':
                ls += 1
            else:
                rs += 1
            if ls == rs:
                result += 1
                ls = 0
                rs = 0

        return result