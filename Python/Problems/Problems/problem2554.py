from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2554(Problem):
    def test(self) -> bool:
        banned = [1, 6, 5]
        n = 5
        maxSum = 6

        expected = 2

        result = self.maxCount(banned, n, maxSum)

        print(result)

        return expected == result

    def maxCount(self, banned: List[int], n: int, maxSum: int) -> int:
        result = 0
        cSum = 0
        bannedSet = set(banned)
        for i in range(1, n + 1):
            if cSum + i > maxSum:
                break
            if i in bannedSet:
                continue

            cSum += i
            result += 1

        return result