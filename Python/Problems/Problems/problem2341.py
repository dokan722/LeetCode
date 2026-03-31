import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2341(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2, 1, 3, 2, 2]

        expected = [3, 1]

        result = self.numberOfPairs(nums)

        print1DArray(result)

        return expected == result

    def numberOfPairs(self, nums: List[int]) -> List[int]:
        n = len(nums)
        present = [False] * 101
        rem = n
        for num in nums:
            if present[num]:
                rem -= 2
                present[num] = False
            else:
                present[num] = True
        return [(n - rem) // 2, rem]