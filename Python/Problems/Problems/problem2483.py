import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2483(Problem):
    def test(self) -> bool:
        customers = "YYNY"

        expected = 2

        result = self.bestClosingTime(customers)

        print(result)

        return result == expected

    def bestClosingTime(self, customers: str) -> int:
        n = len(customers)
        ys = 0
        for c in customers:
            if c == 'Y':
                ys += 1

        ns = 0
        minPen = ys
        result = 0
        for i in range(n):
            if customers[i] == 'N':
                ns += 1
            else:
                ys -= 1
            pen = ns + ys
            if pen < minPen:
                minPen = pen
                result = i + 1
        return result