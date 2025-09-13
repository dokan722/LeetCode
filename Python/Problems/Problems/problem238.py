from typing import List

from .problem import Problem


class Problem238(Problem):
    def test(self) -> bool:
        nums = [1, 2, 3, 4]

        expected = [24, 12, 8, 6]

        result = self.productExceptSelf(nums)

        return expected == result

    def productExceptSelf(self, nums: List[int]) -> List[int]:
        n = len(nums)
        product = 1
        zeroCount = 0
        zeroId = -1
        for i in range(n):
            if nums[i] != 0:
                product *= nums[i]
            else:
                zeroCount += 1
                if zeroCount > 1:
                    return [0] * n
                zeroId = i

        if zeroCount == 1:
            result = [0] * n
            result[zeroId] = product
            return result

        for i in range(n):
            nums[i] = product // (nums[i] if nums[i] != 0 else 1)


        return nums
