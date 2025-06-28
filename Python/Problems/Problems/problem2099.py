from .problem import Problem


class Problem2099(Problem):
    def test(self):
        nums = [2, 1, 3, 3]
        k = 2

        expected = [3, 3]

        result = self.maxSubsequence(nums, k)


        return result == expected

    def maxSubsequence(self, nums, k):
        indexed = []
        for i in range(len(nums)):
            indexed.append([i, nums[i]])
        indexed.sort(key=lambda x: x[1])
        result = indexed[-k:]
        result.sort(key=lambda x: x[0])
        return [x[1] for x in result]