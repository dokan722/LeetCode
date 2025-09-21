from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem961(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 3]

        expected = 3

        result = self.repeatedNTimes(nums)

        print(result)

        return result == expected

    def repeatedNTimes(self, nums: List[int]) -> int:
        s = set()
        for num in nums:
            if num in s:
                return num
            s.add(num)


        return 0
