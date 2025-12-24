import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3074(Problem):
    def test(self) -> bool:
        apple = [1, 3, 2]
        capacity = [4, 3, 1, 5, 2]

        expected = 2

        result = self.minimumBoxes(apple, capacity)

        print(result)

        return result == expected

    def minimumBoxes(self, apple: List[int], capacity: List[int]) -> int:
        m = len(capacity)
        appleSum = sum(apple)

        capacity.sort()
        i = m - 1
        while appleSum > 0:
            appleSum -= capacity[i]
            i -= 1

        return m - i - 1