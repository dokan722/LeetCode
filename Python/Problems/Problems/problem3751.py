import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3751(Problem):
    def test(self) -> bool:
        num1 = 120
        num2 = 130

        expected = 3

        result = self.totalWaviness(num1, num2)

        print(result)

        return result == expected

    def totalWaviness(self, num1: int, num2: int) -> int:
        result = 0
        start = max(100, num1)
        for i in range(start, num2 + 1):
            cur = str(i)
            l = len(cur)
            for j in range(1, l - 1):
                if (ord(cur[j]) < ord(cur[j - 1]) and ord(cur[j]) < ord(cur[j + 1])) or (ord(cur[j]) > ord(cur[j - 1]) and ord(cur[j]) > ord(cur[j + 1])):
                    result += 1


        return result