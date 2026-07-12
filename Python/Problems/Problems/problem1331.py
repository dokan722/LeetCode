import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1331(Problem):
    def test(self) -> bool:
        arr = [40, 10, 20, 30]

        expected = [4, 1, 2, 3]

        result = self.arrayRankTransform(arr)

        print1DArray(result)

        return expected == result

    def arrayRankTransform(self, arr: List[int]) -> List[int]:
        n = len(arr)
        dic = dict()
        sorted = list(arr)
        sorted.sort()
        cur = 1
        for i in range(n):
            if sorted[i] not in dic:
                dic[sorted[i]] = cur
                cur += 1
        result = [0] * n
        for i in range(n):
            result[i] = dic[arr[i]]

        return result