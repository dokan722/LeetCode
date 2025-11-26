import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1015(Problem):
    def test(self) -> bool:
        k = 3

        expected = 3

        result = self.smallestRepunitDivByK(k)

        print(result)

        return result == expected

    def smallestRepunitDivByK(self, k: int) -> int:
        num = 1
        seen = set()
        for i in range(k + 1):
            num %= k
            if num == 0:
                return i + 1
            seen.add(num)
            num = num * 10 + 1

        return -1