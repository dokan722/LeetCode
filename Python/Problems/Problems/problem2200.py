from .problem import Problem

class Problem2200(Problem):
    def test(self):
        nums = [3, 4, 9, 1, 3, 9, 5]

        key = 9
        k = 1

        expected = [1, 2, 3, 4, 5, 6]

        result = self.findKDistantIndices(nums, key, k)

        return expected == result

    def findKDistantIndices(self, nums, key, k):
        right = 0
        result = []

        for i in range(len(nums)):
            if nums[i] == key:
                left = max(right, i - k)
                right = min(len(nums), i + k + 1)
                for j in range(left, right):
                    result.append(j)

        return result