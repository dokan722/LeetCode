from typing import List

from .problem import Problem


class Problem3392(Problem):
    def test(self) -> bool:
        nums = [1, 2, 1, 4, 1]

        expected = 1

        result = self.countSubarrays(nums)

        return result == expected

    def countSubarrays(self, nums: List[int]) -> int:
        result = 0
        for i in range(1, len(nums) - 1):
            if 2 * (nums[i - 1] + nums[i + 1]) == nums[i]:
                result += 1

        return result