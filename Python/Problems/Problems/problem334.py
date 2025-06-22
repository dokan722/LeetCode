import sys

from .problem import Problem

class Problem334(Problem):
    def test(self):
        nums = [1, 2, 3, 4, 5]

        expected = True

        result = self.increasingTriplet(nums)

        print(result)

        return expected == result

    def increasingTriplet(self, nums):
        first = sys.maxsize
        second = sys.maxsize

        for i in range(len(nums)):
            if nums[i] <= first:
                first = nums[i]
            elif nums[i] <= second:
                second = nums[i]
            else:
                return True

        return False