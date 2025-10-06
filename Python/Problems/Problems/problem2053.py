import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2053(Problem):
    def test(self) -> bool:
        arr = ["d", "b", "c", "b", "c", "a"]
        k = 2

        expected = "a"

        result = self.kthDistinct(arr, k)

        print(result)

        return expected == result

    def kthDistinct(self, arr: List[str], k: int) -> str:
        present = dict()
        for s in arr:
            if s in present:
                present[s] += 1
            else:
                present[s] = 1
        num = 0
        for s in arr:
            if present[s] > 1:
                continue
            num += 1
            if num == k:
                return s

        return ""