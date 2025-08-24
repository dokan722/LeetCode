from typing import List

from .problem import Problem


class Problem918(Problem):
    def test(self) -> bool:
        nums = [5, -3, 5]

        expected = 10

        result = self.maxSubarraySumCircular(nums)

        print(result)

        return result == expected

    def maxSubarraySumCircular(self, nums: List[int]) -> int:
        runningMax = nums[0]
        runningMin = nums[0]
        maxSum = nums[0]
        minSum = nums[0]
        sum = nums[0]
        for i in range(1, len(nums)):
            runningMax = max(nums[i], runningMax + nums[i])
            runningMin = min(nums[i], runningMin + nums[i])

            maxSum = max(maxSum, runningMax)
            minSum = min(minSum, runningMin)

            sum += nums[i]

        if sum == minSum:
            return maxSum

        return max(maxSum, sum - minSum)