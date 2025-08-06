from typing import List

from .problem import Problem


class Problem645(Problem):
    def test(self) -> bool:
        nums = [1, 2, 2, 4]

        expected = [2, 3]

        result = self.findErrorNums(nums)

        return result == expected

    def findErrorNums(self, nums: List[int]) -> List[int]:
        n = len(nums)
        presence = [False] * n
        result = [0, 0]
        for num in nums:
            if presence[num - 1]:
                result[0] = num
            presence[num - 1] = True
        for i in range(n):
            if not presence[i]:
                result[1] = i + 1
                break

        return result