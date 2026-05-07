import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3842(Problem):
    def test(self) -> bool:
        nums = [10, 30, 20, 10]

        expected = [20, 30]

        result = self.toggleLightBulbs(nums)

        print1DArray(result)

        return expected == result

    def toggleLightBulbs(self, bulbs: list[int]) -> list[int]:
        bb = [False] * 101
        for b in bulbs:
            bb[b] = not bb[b]

        result = []
        for i in range(101):
            if bb[i]:
                result.append(i)
        return result