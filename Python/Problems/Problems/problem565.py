import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem565(Problem):
    def test(self) -> bool:
        nums = [5, 4, 0, 3, 1, 6, 2]

        expected = 4

        result = self.arrayNesting(nums)

        print(result)

        return expected == result

    def arrayNesting(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        for i in range(n):
            l = 1
            if nums[i] != -1:
                cur = nums[i]
                nums[i] = -1
                while cur != i:
                    l += 1
                    val = nums[cur]
                    nums[cur] = -1
                    cur = val
            result = max(result, l)

        return result