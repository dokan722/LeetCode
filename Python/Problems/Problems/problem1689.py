import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1689(Problem):
    def test(self) -> bool:
        n = "27346209830709182346"

        expected = 9

        result = self.minPartitions(n)

        print(result)

        return result == expected

    def minPartitions(self, n: str) -> int:
        maxDigit = '1'
        for i in n:
            if ord(i) > ord(maxDigit):
                if i == '9':
                    return 9
                maxDigit = i

        return ord(maxDigit) - ord('0')