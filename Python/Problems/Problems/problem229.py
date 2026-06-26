import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem229(Problem):
    def test(self) -> bool:
        nums = [2, 2]

        expected = [2]

        result = self.majorityElement(nums)

        print1DArray(result)

        return expected == result

    def majorityElement(self, nums: List[int]) -> List[int]:
        n = len(nums)
        k = 2
        if k >= n:
            return list(set(nums))

        cands = [-sys.maxsize] * k
        counts = [0] * k

        for i in range(n):
            present = False
            for j in range(k):
                if nums[i] == cands[j]:
                    counts[j] += 1
                    present = True
                    break
            replaced = present
            if not present:
                for j in range(k):
                    if counts[j] == 0:
                        cands[j] = nums[i]
                        replaced = True
                        counts[j] = 1
                        break
            if not replaced:
                for j in range(k):
                    counts[j] -= 1
        result = []
        for i in range(k):
            counts[i] = 0
        for i in range(n):
            for j in range(k):
                if cands[j] != -sys.maxsize and cands[j] == nums[i]:
                    counts[j] += 1
        for i in range(k):
            if counts[i] > n / 3:
                result.append(cands[i])

        return result