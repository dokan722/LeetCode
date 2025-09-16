from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem2640(Problem):
    def test(self) -> bool:
        nums = [2, 3, 7, 5, 10]

        expected = [4, 10, 24, 36, 56]

        result = self.findPrefixScore(nums)

        print1DArray(result)

        return result == expected

    def findPrefixScore(self, nums: List[int]) -> List[int]:
        n = len(nums)
        result = []
        m = nums[0]
        result.append(2 * m)
        for i in range(1, n):
            m = max(m, nums[i])
            result.append(result[i - 1] + nums[i] + m)

        return result