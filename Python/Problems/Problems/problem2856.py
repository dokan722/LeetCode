from .problem import Problem


class Problem2856(Problem):
    def test(self):
        nums = [1, 2, 3, 4]

        expected = 0

        result = self.minLengthAfterRemovals(nums)

        print(result)

        return result == expected

    def minLengthAfterRemovals(self, nums):
        n = len(nums)
        if n < 2:
            return n
        left = 0
        right = n - 1
        med = nums[n // 2]
        while nums[left] < med:
            left += 1
        while nums[right] > med:
            right -= 1
        lesser = left
        bigger = n - 1 - right
        equal = n - lesser - bigger
        if lesser + bigger > equal:
            return n % 2

        return equal - lesser - bigger