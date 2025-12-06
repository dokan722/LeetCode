import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from sortedcontainers import SortedList
from collections import Counter

from .problem import Problem


class Problem3578(Problem):
    def test(self) -> bool:
        nums = [9, 4, 1, 3, 7]
        k = 4

        expected = 6

        result = self.countPartitions(nums, k)

        print(result)

        return result == expected

    def countPartitions(self, nums: List[int], k: int) -> int:
        n = len(nums)
        mod = 10 ** 9 + 7
        dp = [0] * (n + 1)
        prefix = [0] * (n + 1)
        cnt = SortedList()

        dp[0] = 1
        prefix[0] = 1

        j = 0
        for i in range(n):
            cnt.add(nums[i])
            while j <= i and cnt[-1] - cnt[0] > k:
                cnt.remove(nums[j])
                j += 1
            dp[i + 1] = (prefix[i] - (prefix[j - 1] if j > 0 else 0)) % mod
            prefix[i + 1] = (prefix[i] + dp[i + 1]) % mod

        return dp[n]