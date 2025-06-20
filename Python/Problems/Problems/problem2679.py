from .problem import Problem

class Problem2679(Problem):
    def test(self):
        matrix = [[7, 2, 1], [6, 4, 2], [6, 5, 3], [3, 2, 1]]

        expected = 15

        result = self.matrixSum(matrix)

        print(result)

        return expected == result

    def matrixSum(self, nums):
        n = len(nums)
        m = len(nums[0])
        for i in range(n):
            nums[i].sort()

        result = 0

        for i in range(m):
            max = 0;
            for j in range(n):
                if nums[j][i] > max:
                    max = nums[j][i]
            result += max

        return result