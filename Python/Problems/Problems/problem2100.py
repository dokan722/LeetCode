import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2100(Problem):
    def test(self) -> bool:
        security = [5, 3, 3, 3, 5, 6, 2]
        time = 2

        expected = [3, 2]

        result = self.goodDaysToRobBank(security, time)

        print1DArray(result)

        return expected == result

    def goodDaysToRobBank(self, security: List[int], time: int) -> List[int]:
        n = len(security)
        if time == 0:
            return [i for i in range(n)]
        before = [0] * n
        for i in range(1, n):
            if security[i - 1] >= security[i]:
                before[i] = before[i - 1] + 1
            else:
                before[i] = 0
        after = 0
        result = []
        for i in range(n - 2, 0, -1):
            if security[i + 1] >= security[i]:
                after += 1
            else:
                after = 0
            if before[i] >= time and after >= time:
                result.append(i)

        return result