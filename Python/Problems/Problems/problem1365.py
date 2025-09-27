from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem1365(Problem):
    def test(self) -> bool:
        nums = [8, 1, 2, 2, 3]

        expected = [4, 0, 1, 1, 3]

        result = self.smallerNumbersThanCurrent(nums)

        print1DArray(result)

        return result == expected

    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        counts = [0] * 101
        for num in nums:
            counts[num] += 1

        smaller = [0] * 102
        smaller[0] = 0
        for i in range(1, 102):
            smaller[i] = counts[i - 1] + smaller[i - 1]

        for i in range(len(nums)):
            nums[i] = smaller[nums[i]]

        return nums