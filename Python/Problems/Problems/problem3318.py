import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem3318(Problem):
    def test(self) -> bool:
        nums = [3, 8, 7, 8, 7, 5]
        k = 2
        x = 2

        expected = [11, 15, 15, 15, 12]

        result = self.findXSum(nums, k, x)

        print1DArray(result)

        return expected == result

    def findXSum(self, nums: List[int], k: int, x: int) -> List[int]:
        n = len(nums)
        counts = [0] * 51
        for i in range(k):
            counts[nums[i]] += 1

        rLen = n - k + 1
        result = [0] * rLen
        for i in range(rLen):
            cRes = 0
            que = []
            for j in range(51):
                if counts[j] > 0:
                    heapq.heappush(que, (-counts[j], -j))
            j = 0
            while j < x and que:
                count = heapq.heappop(que)
                cRes += -count[0] * -count[1]
                j += 1

            counts[nums[i]] -= 1
            if i + k < n:
                counts[nums[i + k]] += 1
            result[i] = cRes

        return result