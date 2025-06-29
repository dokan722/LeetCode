from .problem import Problem


class Problem1498(Problem):
    def test(self):
        nums = [2, 3, 3, 4, 6, 7]
        target = 12

        expected = 61

        result = self.numSubseq(nums, target)

        print(result)

        return expected == result

    def numSubseq(self, nums, target):
        nums.sort()
        powers = []
        mod = 10 ** 9 + 7
        powers.append(1)
        for i in range(1, len(nums)):
            powers.append((powers[i - 1] * 2) % mod)
        result = 0
        left = 0
        right = len(nums) - 1
        while left <= right:
            if nums[left] + nums[right] <= target:
                result = (result + powers[right - left]) % mod
                left += 1
            else:
                right -= 1

        return result