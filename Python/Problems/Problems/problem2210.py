from typing import List

from .problem import Problem


class Problem2210(Problem):
    def test(self) -> bool:
        nums = [2, 4, 1, 1, 6, 5]

        expected = 3

        result = self.countHillValley(nums)

        print(result)

        return result == expected

    def countHillValley(self, nums: List[int]) -> int:
        n = len(nums)
        result = 0
        prev = 0
        i = 0
        while i < n:
            while i < n and nums[i] == nums[prev]:
                i += 1
            if i == n:
                break
            next = i
            while next < n and nums[next] == nums[i]:
                next += 1
            if next == n:
                break
            if ((nums[prev] < nums[i] and nums[next] < nums[i]) or
                    (nums[prev] > nums[i] and nums[next] > nums[i])):
                result += 1
            prev = i
            i = next - 1


        return result