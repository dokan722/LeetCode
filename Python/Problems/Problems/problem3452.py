from typing import List, Dict

from .problem import Problem


class Problem3452(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2, 1, 5, 4]
        k = 2

        expected = 12

        result = self.sumOfGoodNumbers(nums, k)

        print(result)

        return result == expected

    def sumOfGoodNumbers(self, nums: List[int], k: int) -> int:
        result = 0
        for i in range(len(nums)):
            if nums[i] > self.getNum(i + k, nums) and nums[i] > self.getNum(i - k, nums):
                result += nums[i]

        return result

    def getNum(self, id: int, nums: List[int]) -> int:
        if id < 0 or  id >= len(nums):
            return -1
        return nums[id]