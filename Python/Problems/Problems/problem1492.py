import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1492(Problem):
    def test(self) -> bool:
        n = 12
        k = 3

        expected = 3

        result = self.kthFactor(n, k)

        print(result)

        return expected == result

    def kthFactor(self, n: int, k: int) -> int:
        limit = math.sqrt(n)
        for i in range(1, math.ceil(limit)):
            if n % i == 0:
                k -= 1
                if k == 0:
                    return i

        for i in range(int(limit), 0, -1):
            div = n // i
            if n %div == 0:
                k -= 1
                if k == 0:
                    return div

        return -1