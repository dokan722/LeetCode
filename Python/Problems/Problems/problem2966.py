from .problem import Problem
import numpy as np

class Problem2966(Problem):
    def test(self):
        nums = [1, 3, 4, 8, 7, 9, 3, 5, 1]

        k = 2

        expected = [[1, 1, 3], [3, 4, 5], [7, 8, 9]]

        result = self.divideArray(nums, k)

        if len(result) != len(expected):
            return False

        for arr in expected:
            if (arr not in result):
                return False

        return True

    def divideArray(self, nums, k):
        nums = np.sort(nums)
        results = []

        for i in range(0, len(nums), 3):
            if nums[i + 2] - nums[i] > k:
                return []
            results += [[nums[i], nums[i + 1], nums[i + 2]]]

        return results