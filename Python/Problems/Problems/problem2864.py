import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2864(Problem):
    def test(self) -> bool:
        s = "0101"

        expected = "1001"

        result = self.maximumOddBinaryNumber(s)

        print(result)

        return expected == result

    def maximumOddBinaryNumber(self, s: str) -> str:
        zeros = 0
        ones = -1
        for c in s:
            if c == '0':
                zeros += 1
            else:
                ones += 1

        return '1' * ones + '0' * zeros + '1'
