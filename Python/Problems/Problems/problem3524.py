import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3524(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4, 5]
        k = 3

        expected = [9, 2, 4]

        result = self.resultArray(nums, k)

        print1DArray(result)

        return expected == result

    def resultArray(self, nums: List[int], k: int) -> List[int]:
        result = [0] * k
        prev = [0] * k
        for num in nums:
            rem = num % k
            next = [0] * k
            for i in range(k):
                next[(i * rem) % k] += prev[i]
            next[rem] += 1
            for i in range(k):
                result[i] += next[i]
            prev = next

        return result