from .problem import Problem


class Problem1920(Problem):
    def test(self):
        nums = [0, 2, 1, 5, 3, 4]
        expected = [0, 1, 2, 4, 5, 3]

        result = self.buildArray(nums)

        print(','.join(map(str, result)))

        return result == expected

    def buildArray(self, nums):
        n = len(nums)
        for i in range(n):
            nums[i] += 1000 * (nums[nums[i]] % 1000)

        for i in range(n):
            nums[i] //= 1000
        return nums