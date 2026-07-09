import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2844(Problem):
    def test(self) -> bool:
        num = "2245047"

        expected = 2

        result = self.minimumOperations(num)

        print(result)

        return result == expected

    def minimumOperations(self, num: str) -> int:
        zero = False
        five = False
        zeros = 0
        n = len(num)
        for i in range(n - 1, -1, -1):
            if zero and (num[i] == '5' or num[i] == '0'):
                return n - i - 2
            if five and (num[i] == '2' or num[i] == '7'):
                return n - i - 2
            if (num[i] == '0'):
                zeros += 1
                zero = True
            elif num[i] == '5':
                five = True

        return n - zeros