from .problem import Problem
import math

class Problem2616(Problem):
    def test(self):
        s = [ 3, 4, 2, 3, 2, 1, 2 ]
        p = 3
        expected = 1

        result = self.minimizeMax(s, p)

        print(result)

        return expected == result

    def minimizeMax(self, nums, p):
        nums.sort()
        left = 0
        right = nums[-1] - nums[0]

        while left < right:
            mid = (left + right) // 2
            count = self.countDiffs(nums, mid)
            if count < p:
                left = mid + 1
            else:
                right = mid

        return left


    def countDiffs(self, nums, maxDiff):
        count = 0
        i = 0
        while i < len(nums) - 1:
            if abs(nums[i] - nums[i + 1]) <= maxDiff:
                i += 1
                count += 1
            i += 1
        return count