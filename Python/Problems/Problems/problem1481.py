import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1481(Problem):
    def test(self) -> bool:
        arr = [5, 5, 4]
        k = 1

        expected = 1

        result = self.findLeastNumOfUniqueInts(arr, k)

        print(result)

        return result == expected

    def findLeastNumOfUniqueInts(self, arr: List[int], k: int) -> int:
        counts = dict()
        for num in arr:
            if num in counts:
                counts[num] += 1
            else:
                counts[num] = 1
        freq = list(counts.values())
        freq.sort()
        end = 0
        m = len(freq)
        while end < m and k >= freq[end]:
            k -= freq[end]
            end += 1
        return m - end