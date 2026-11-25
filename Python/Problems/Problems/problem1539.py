import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1539(Problem):
    def test(self) -> bool:
        arr = [2, 3, 4, 7, 11]
        k = 5

        expected = 9

        result = self.findKthPositive(arr, k)

        print(result)

        return result == expected

    def findKthPositive(self, arr: list[int], k: int) -> int:
        cur = k
        for num in arr:
            if cur < num:
                return cur
            cur += 1

        return cur