import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem1390(Problem):
    def test(self) -> bool:
        nums = [21, 4, 7]

        expected = 32

        result = self.sumFourDivisors(nums)

        print(result)

        return expected == result

    def sumFourDivisors(self, nums: List[int]) -> int:
        result = 0

        for num in nums:
            sq = math.sqrt(num)
            divs = 1 if int(sq) * int(sq) == num else 0
            sum = int(sq * divs)
            for i in range(1 , int(sq) + 1):
                if num % i == 0:
                    sum += i + num // i
                    divs += 2

            if divs == 4:
                result += sum

        return result