import sys
from typing import List

from .problem import Problem

class Problem3202(Problem):
    def test(self) -> bool:
        nums = [1, 4, 2, 3, 1, 4]
        k = 3

        expected = 4

        result = self.maximumLength(nums, k)

        print(result)

        return expected == result

    def maximumLength(self, nums: List[int], k: int) -> int:
        lengths = [[0] * k for _ in range(k)]
        for num in nums:
            mod = num % k
            for j in range(k):
                lengths[mod][j] = (lengths[j][mod] + 1)

        result = -sys.maxsize
        for i in range(k):
            for j in range(k):
                if lengths[i][j] > result:
                    result = lengths[i][j]

        return result