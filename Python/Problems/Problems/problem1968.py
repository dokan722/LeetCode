from .problem import Problem


class Problem1968(Problem):
    def test(self):
        nums = [1, 2, 3, 4, 5]

        expected = [1, 3, 2, 5, 4]

        result = self.rearrangeArray(nums)

        return expected == result

    def rearrangeArray(self, nums):
        for i in range(1, len(nums) - 1):
            if (nums[i - 1] < nums[i] < nums[i + 1]) or (nums[i - 1] > nums[i] > nums[i + 1]):
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i])

        return nums