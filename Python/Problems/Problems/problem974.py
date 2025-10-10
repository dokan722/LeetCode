import heapq

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem974(Problem):
    def test(self) -> bool:
        nums = [4, 5, 0, -2, -3, 1]
        k = 5

        expected = 7

        result = self.subarraysDivByK(nums, k)

        print(result)

        return expected == result

    def subarraysDivByK(self, nums: List[int], k: int) -> int:
        n = len(nums)
        mods = [0] * k
        mods[0] = 1
        sum = 0
        result = 0
        for i in range(n):
            sum += nums[i]
            mod = sum % k
            result += mods[mod]
            mods[mod] += 1

        return result