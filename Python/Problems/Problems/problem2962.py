from typing import List

from .problem import Problem


class Problem2962(Problem):
    def test(self) -> bool:
        nums = [1, 3, 2, 3, 3]
        k = 2

        expected = 6

        result = self.countSubarrays(nums, k)

        print(result)

        return result == expected

    def countSubarrays(self, nums: List[int], k: int) -> int:
        n = len(nums)
        m = max(nums)
        count = 0
        result = 0
        j = 0
        for i in range(n):
            if nums[i] == m:
                count += 1
            while j < n and count >= k:
                result += n - i
                if nums[j] == m:
                    count -= 1
                j += 1

        return result