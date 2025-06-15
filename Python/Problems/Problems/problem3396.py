from .problem import Problem
import numpy as np

class Problem3396(Problem):
    def test(self):
        nums = [4, 5, 6, 4, 4]

        expected = 2

        result = self.minimumOperations(nums)

        print(result)

        return expected == result

    def minimumOperations(self, nums):
        found = [False for _ in range(100)]
        i = len(nums) - 1

        while i >= 0:
            if found[nums[i] - 1]:
                break
            found[nums[i] - 1] = True
            i -= 1

        return int(np.ceil((i + 1) / 3.0))