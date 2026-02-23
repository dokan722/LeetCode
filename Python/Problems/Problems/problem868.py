import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem868(Problem):
    def test(self) -> bool:
        n = 22

        expected = 2

        result = self.binaryGap(n)

        print(result)

        return result == expected

    def binaryGap(self, n: int) -> int:
        if n.bit_count() < 2:
            return 0

        while n % 2 == 0:
            n >>= 1
        result = 0
        count = 0
        while n != 0:
            n >>= 1
            if n % 2 == 1:
                result = max(result, count + 1)
                count = 0
            else:
                count += 1

        return result