import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2169(Problem):
    def test(self) -> bool:
        num1 = 2
        num2 = 3

        expected = 3

        result = self.countOperations(num1, num2)

        print(result)

        return result == expected

    def countOperations(self, num1: int, num2: int) -> int:
        if num1 < num2:
            return self.countOperations(num2, num1)
        if num2 == 0:
            return 0
        ops = num1 // num2
        next = num1 % num2
        return ops + self.countOperations(num2, next)