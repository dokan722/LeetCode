import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3895(Problem):
    def test(self) -> bool:
        nums = [12, 54, 32, 22]
        digit = 2

        expected = 4

        result = self.countDigitOccurrences(nums, digit)

        print(result)

        return result == expected

    def countDigitOccurrences(self, nums: list[int], digit: int) -> int:
        result = 0
        for num in nums:
            cur = num
            while cur > 0:
                if cur % 10 == digit:
                    result += 1
                cur //= 10

        return result