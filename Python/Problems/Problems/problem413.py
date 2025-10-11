import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem413(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = 3

        result = self.numberOfArithmeticSlices(nums)

        print(result)

        return expected == result

    def numberOfArithmeticSlices(self, nums: List[int]) -> int:
        n = len(nums)
        if n < 3:
            return 0
        result = 0
        start = 0
        prevDiff = nums[0] - nums[1]
        for i in range(2, n):
            diff = nums[i - 1] - nums[i]
            if diff == prevDiff:
                continue
            l = i - start
            if l >= 3:
                result += (l - 2) * (l - 1) / 2
            start = i - 1
            prevDiff = diff

        final = n - start
        if final >= 3:
            result += (final - 2) * (final - 1) / 2

        return result