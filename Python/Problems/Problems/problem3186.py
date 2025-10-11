import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3186(Problem):
    def test(self) -> bool:
        power = [7, 1, 6, 6]

        expected = 13

        result = self.maximumTotalDamage(power)

        print(result)

        return expected == result

    def maximumTotalDamage(self, power: List[int]) -> int:
        counts = dict()
        for p in power:
            if p in counts:
                counts[p] += 1
            else:
                counts[p] = 1

        n = len(counts)
        values = list(counts.keys())
        values.sort()
        dp = [0] * n
        result = 0
        mx = 0
        j = 0
        for i in range(n):
            value = values[i]
            while j < i and values[j] < value - 2:
                mx = max(mx, dp[j])
                j += 1
            dp[i] = mx + counts[value] * value
            result = max(result, dp[i])

        return result
