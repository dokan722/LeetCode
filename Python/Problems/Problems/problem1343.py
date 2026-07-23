import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1343(Problem):
    def test(self) -> bool:
        arr = [2, 2, 2, 2, 5, 5, 5, 8]
        k = 3
        threshold = 4

        expected = 3

        result = self.numOfSubarrays(arr, k, threshold)

        print(result)

        return result == expected

    def numOfSubarrays(self, arr: List[int], k: int, threshold: int) -> int:
        n = len(arr)
        cur = 0
        for i in range(k):
            cur += arr[i]
        result = 1 if cur // k >= threshold else 0
        for i in range(n - k):
            cur -= arr[i]
            cur += arr[i + k]
            if cur / k >= threshold:
                result += 1

        return result