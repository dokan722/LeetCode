from .problem import Problem
import sys

class Problem2016(Problem):
    def test(self):
        nums = [9,4,3,2]

        expected = -1

        result = self.maximumDifference(nums)

        print(result)

        return expected == result

    def maximumDifference(self, nums):
        result = -sys.maxsize

        minSoFar = sys.maxsize

        for i in range (1, len(nums)):
            if nums[i - 1] < minSoFar:
                minSoFar = nums[i - 1]
            diff = nums[i] - minSoFar
            if diff > result:
                result = diff

        return -1 if result <= 0 else result