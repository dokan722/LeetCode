import heapq
from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1415(Problem):
    def test(self) -> bool:
        n = 3
        k = 9

        expected = "cab"

        result = self.getHappyString(n, k)

        print(result)

        return expected == result

    def getHappyString(self, n: int, k: int) -> str:
        chars = ['a', 'b', 'c']
        result = ["a", "b", "c"]
        for i in range(1, n):
            newResult = []
            for s in result:
                for c in chars:
                    if c == s[-1]:
                        continue
                    newResult.append(s + c)

            result = newResult

        if k > len(result):
            return ""

        return result[k - 1]