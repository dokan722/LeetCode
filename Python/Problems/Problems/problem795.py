from typing import List, Dict

from .problem import Problem


class Problem795(Problem):
    def test(self) -> bool:
        nums = [2, 9, 2, 5, 6]
        left = 2
        right = 8

        expected = 7

        result = self.numSubarrayBoundedMax(nums, left, right)

        print(result)

        return expected == result

    def numSubarrayBoundedMax(self, nums: List[int], left: int, right: int) -> int:
        n = len(nums)
        count = 0
        properElements = []
        result = 0
        for i in range(n):
            if nums[i] <= right:
                if nums[i] >= left:
                    properElements.append(i)
                count += 1
            else:
                if properElements and count > 0:
                    result += self.getProperSubarrays(i, count, properElements)
                count = 0
                properElements.clear()
        if properElements and count > 0:
            result += self.getProperSubarrays(n, count, properElements)

        return result

    def getProperSubarrays(self, index: int, count: int, properElements: List[int]) -> int:
        start = index - count
        result = 0
        for properElement in properElements:
            result += (properElement - start + 1) * (index - properElement)
            start = properElement + 1
        return result