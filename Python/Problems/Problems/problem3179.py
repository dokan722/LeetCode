import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3179(Problem):
    def test(self) -> bool:
        n = 4
        k = 5

        expected = 56

        result = self.valueAfterKSeconds(n, k)

        print(result)

        return result == expected

    def valueAfterKSeconds(self, n: int, k: int) -> int:
        arr = [1] * n
        mod = 1000000007
        for i in range(k):
            for j in range(1, n):
                arr[j] = (arr[j - 1] + arr[j]) % mod
        return arr[n - 1]