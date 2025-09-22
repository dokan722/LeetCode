from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2779(Problem):
    def test(self) -> bool:
        nums = [4, 6, 1, 2]
        k = 2

        expected = 3

        result = self.maximumBeauty(nums, k)

        print(result)

        return result == expected

    def maximumBeauty(self, nums: List[int], k: int) -> int:
        maxValue = 0
        for num in nums:
            maxValue = max(maxValue, num)
        r = maxValue + 2 * (k + 1)
        intervals = [0] * r

        for num in nums:
            intervals[num] += 1
            intervals[num + 2 * k + 1] -= 1
        inside = 0
        result = 0

        for i in range(r):
            if intervals[i] != 0:
                inside += intervals[i]
                result = max(result, inside)


        return result