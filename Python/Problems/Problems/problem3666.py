import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3666(Problem):
    def test(self) -> bool:
        s = "0101"
        k = 3

        expected = 2

        result = self.minOperations(s, k)

        print(result)

        return result == expected

    def minOperations(self, s: str, k: int) -> int:
        n = len(s)
        zeros = 0
        for c in s:
            if c == '0':
                zeros += 1

        if zeros == 0:
            return 0
        if n == k:
            return 1 if zeros == n else -1
        ones = n - zeros
        b = n - k
        result = sys.maxsize
        if k % 2 == zeros % 2:
            result = max((zeros + k - 1) // k, (ones + b - 1) // b)
            if result % 2 == 0:
                result += 1
        if zeros % 2 == 0:
            even = max((zeros + k - 1) // k, (zeros + b - 1) // b)
            if even % 2 == 1:
                even += 1
            result = min(result, even)

        return -1 if result == sys.maxsize else result