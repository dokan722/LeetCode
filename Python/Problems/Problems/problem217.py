import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem217(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 1]

        expected = True

        result = self.containsDuplicate(nums)

        print(result)

        return expected == result

    def containsDuplicate(self, nums: List[int]) -> bool:
        s = set()
        for n in nums:
            if n in s:
                return True
            s.add(n)

        return False