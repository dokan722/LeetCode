import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3494(Problem):
    def test(self) -> bool:
        skill = [1, 5, 2, 4]
        mana = [5, 1, 4, 2]

        expected = 110

        result = self.minTime(skill, mana)

        print(result)

        return expected == result

    def minTime(self, skill: List[int], mana: List[int]) -> int:
        n = len(skill)
        m = len(mana)
        times = [0] * (n + 1)
        for i in range(m):
            for j in range(1, n + 1):
                times[j] = max(times[j], times[j - 1]) + mana[i] * skill[j - 1]
            for j in range(n - 1, -1, -1):
                times[j] = times[j + 1] - mana[i] * skill[j]
        return times[n]