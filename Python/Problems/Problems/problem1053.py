import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1053(Problem):
    def test(self) -> bool:
        arr = [3, 2, 1]

        expected = [3, 1, 2]

        result = self.prevPermOpt1(arr)

        print1DArray(result)

        return expected == result

    def prevPermOpt1(self, arr: List[int]) -> List[int]:
        n = len(arr)
        for i in range(n - 2, -1, -1):
            if arr[i] > arr[i + 1]:
                m = n - 1
                while arr[m] >= arr[i] or arr[m - 1] == arr[m]:
                    m -= 1
                tmp = arr[i]
                arr[i] = arr[m]
                arr[m] = tmp
                break

        return arr