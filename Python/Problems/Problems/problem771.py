import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem771(Problem):
    def test(self) -> bool:
        jewels = "aA"
        stones = "aAAbbbb"

        expected = 3

        result = self.numJewelsInStones(jewels, stones)

        print(result)

        return result == expected

    def numJewelsInStones(self, jewels: str, stones: str) -> int:
        jewelsSet = set()
        for jewel in jewels:
            jewelsSet.add(jewel)

        result = 0
        for stone in stones:
            if stone in jewelsSet:
                result += 1


        return result