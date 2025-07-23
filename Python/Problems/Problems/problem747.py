from typing import List

from .problem import Problem


class Problem1717(Problem):
    def test(self) -> bool:
        nums = [3, 6, 1, 0]

        expected = 1

        result = self.dominantIndex(nums)

        print(result)

        return expected == result

    def dominantIndex(self, nums: List[int]) -> int:
        max = 0 if nums[0] > nums[1] else 1
        almostMax = 1 if nums[0] > nums[1] else 0

        for i in range(2, len(nums)):
            if nums[i] > nums[max]:
                almostMax = max
                max = i
            elif nums[i] > nums[almostMax]:
                almostMax = i

        if nums[max] >= 2 * nums[almostMax]:
            return max
        return -1