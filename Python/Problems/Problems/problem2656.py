from itertools import repeat

from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2656(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 5]
        k = 3

        expected = 18

        result = self.maximizeSum(nums, k)

        print(result)

        return expected == result

    def maximizeSum(self, nums: List[int], k: int) -> int:
        n = len(nums)
        biggest = nums[0]
        for i in range(1, n):
            biggest = max(biggest, nums[i])
        return biggest * k + ((k - 1) * k // 2)