from typing import List

from .problem import Problem

class Problem1480(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = [1, 3, 6, 10]

        result = self.runningSum(nums)

        print(','.join(map(str, result)))

        return result == expected

    def runningSum(self, nums: List[int]) -> List[int]:
        for i in range(1, len(nums)):
            nums[i] += nums[i - 1]

        return nums