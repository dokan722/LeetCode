import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1550(Problem):
    def test(self) -> bool:
        arr = [2, 6, 4, 1]

        expected = False

        result = self.threeConsecutiveOdds(arr)

        return expected == result

    def threeConsecutiveOdds(self, arr: list[int]) -> bool:
        n = len(arr)
        for i in range(2, n):
            if (arr[i - 2] & 1) == 1 and (arr[i - 1] & 1) == 1 and (arr[i] & 1) == 1:
                return True

        return False