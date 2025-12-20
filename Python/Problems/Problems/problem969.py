import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem969(Problem):
    def test(self) -> bool:
        arr = [3, 2, 4, 1]

        expected = [3, 4, 2, 3, 1, 2]

        result = self.pancakeSort(arr)

        print1DArray(result)

        return result == expected

    def pancakeSort(self, arr: List[int]) -> List[int]:
        n = len(arr)
        result = []
        for i in range(1, n):
            mi = 0
            for j in range(1, n - i + 1):
                if arr[j] > arr[mi]:
                    mi = j
            if mi == n - i:
                continue
            self.flip(mi, arr)
            result.append(mi + 1)
            self.flip(n - i, arr)
            result.append(n - i + 1)
        return result

    def flip(self, k: int, arr: List[int]) -> None:
        for i in range((k // 2) + 1):
            tmp = arr[i]
            arr[i] = arr[k - i]
            arr[k - i] = tmp