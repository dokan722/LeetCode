from typing import List

from .problem import Problem


class Problem525(Problem):
    def test(self) -> bool:
        nums = [0, 1, 1, 1, 1, 1, 0, 0, 0]
        expected = 6

        result = self.findMaxLength(nums)

        print(result)

        return expected == result

    def findMaxLength(self, nums: List[int]) -> int:
        ids = {}
        ids[0] = -1
        runningSum = 0
        result = 0
        for i in range(len(nums)):
            if nums[i] == 0:
                runningSum -= 1
            else:
                runningSum += 1
            if runningSum in ids:
                length = i - ids[runningSum]
                if length > result:
                    result = length
            else:
                ids[runningSum] = i

        return result