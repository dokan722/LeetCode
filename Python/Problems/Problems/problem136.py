from .problem import Problem
from functools import reduce

class Problem136(Problem):
    def test(self):
        nums = [2, 2, 1]

        expected = 1

        result = self.singleNumber(nums)

        print(result)

        return result == expected

    def singleNumber(self, nums):
        return reduce(lambda x, y: x ^ y, nums)