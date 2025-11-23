import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2162(Problem):
    def test(self) -> bool:
        nums = [3, 6, 5, 1, 8]

        expected = 18

        result = self.maxSumDivThree(nums)

        print(result)

        return result == expected

    def maxSumDivThree(self, nums: List[int]) -> int:
        n = len(nums)

        dp = [0, -sys.maxsize, -sys.maxsize]

        for i in range(n):
            curr = [0] * 3
            for j in range(3):
                curr[j] = max(dp[j], dp[(j - (nums[i] % 3) + 3) % 3] + nums[i])
            dp = curr

        return dp[0]