from typing import List, Dict

from .problem import Problem


class Problem2348(Problem):
    def test(self) -> bool:
        nums = [1, 3, 0, 0, 2, 0, 0, 4]

        expected = 6

        result = self.zeroFilledSubarray(nums)

        print(result)

        return result == expected

    def zeroFilledSubarray(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        i = 0
        while i < n:
            if nums[i] == 0:
                begin = i
                while i < n and nums[i] == 0:
                    i += 1
                zeroCount = i - begin
                result += zeroCount * (zeroCount + 1) // 2
            i += 1


        return result