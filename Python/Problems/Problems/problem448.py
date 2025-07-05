from .problem import Problem


class Problem448(Problem):
    def test(self):
        nums = [4, 3, 2, 7, 8, 2, 3, 1]

        expected = [5, 6]

        result = self.findDisappearedNumbers(nums)

        print(', '.join(map(str, result)))

        return result == expected

    def findDisappearedNumbers(self, nums):
        n = len(nums)

        for i in range(n):
            original = (nums[i] - 1) % n
            if nums[original] <= n:
                nums[original] += n

        return [i + 1 for i in range(n) if nums[i] <= n]