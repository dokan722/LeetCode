import sys
from typing import List

from .problem import Problem


class Problem2274(Problem):
    def test(self) -> bool:
        bottom = 2
        top = 9
        special = [4, 6]

        expected = 3

        result = self.maxConsecutive(bottom, top, special)

        print(result)

        return result == expected

    def maxConsecutive(self, bottom: int, top: int, special: List[int]) -> int:
        start = bottom
        special.sort()
        m = -sys.maxsize
        for s in special:
            len = s - start
            if len > m:
                m = len
            start = s + 1

        last = top - start + 1

        return max(last, m)