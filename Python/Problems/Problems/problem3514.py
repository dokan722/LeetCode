import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3514(Problem):
    def test(self) -> bool:
        nums = [6, 7, 8, 9]

        expected = 4

        result = self.uniqueXorTriplets(nums)

        print(result)

        return result == expected

    def uniqueXorTriplets(self, nums: List[int]) -> int:
        mx = max(nums)
        s = 1
        while s <= mx:
            s <<= 1
        one = [False] * s
        two = [False] * s
        three = [False] * s
        for num in nums:
            one[num] = True
            for i in range(s):
                if one[i]:
                    two[i ^ num] = True
        for num in nums:
            for i in range(s):
                if two[i]:
                    three[i ^ num] = True
        return three.count(True)