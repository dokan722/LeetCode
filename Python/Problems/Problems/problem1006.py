import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1006(Problem):
    def test(self) -> bool:
        n = 10

        expected = 12

        result = self.clumsy(n)

        print(result)

        return result == expected

    def clumsy(self, n: int) -> int:
        times = (n // 4) - 1
        rest = n % 4
        curr = 0
        if n >= 4:
            curr += n * (n - 1) // (n - 2) + (n - 3)
            for i in range(times):
                num = n - (i + 1) * 4
                curr -= num * (num - 1) // (num - 2) - (num - 3)
            if rest == 3:
                curr -= 6
            elif rest == 2:
                curr -= 2
            elif rest == 1:
                curr -= 1
        else:
            if rest == 3:
                curr += 6
            elif rest == 2:
                curr += 2
            elif rest == 1:
                curr += 1

        return curr