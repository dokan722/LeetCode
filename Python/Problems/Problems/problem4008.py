import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem4008(Problem):
    def test(self) -> bool:
        monsters = [5, 10, 15]
        boosts = [[1, 1, 10]]

        expected = 30

        result = self.minInitialStrength(monsters, boosts)

        print(result)

        return result == expected

    def minInitialStrength(self, monsters: list[int], boosts: list[list[int]]) -> int:
        n = len(monsters)
        sweep = [0] * (n + 1)
        for boost in boosts:
            sweep[boost[0]] += boost[2]
            sweep[boost[1] + 1] -= boost[2]
        result = 0
        curb = 0
        acc = 0
        for i in range(n):
            curb += sweep[i]
            if curb < monsters[i]:
                result += acc + monsters[i] - curb
                acc = curb
            else:
                acc += monsters[i]
        return result