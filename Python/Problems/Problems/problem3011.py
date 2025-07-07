from .problem import Problem


class Problem3011(Problem):
    def test(self):
        nums = [3, 16, 8, 4, 2]

        expected = False

        result = self.canSortArray(nums)

        return expected == result

    def canSortArray(self, nums):
        n = len(nums)
        bits = [0] * n
        for i in range(n):
            bits[i] = self.countBits(nums[i])
        for i in range(n - 1):
            for j in range(i, n):
                if nums[j] < nums[i] and bits[i] != bits[j]:
                    return False

        return True

    def countBits(self, num):
        bits = 0

        for i in range(10):
            bits += num & 1
            num = (num >> 1)

        return bits