from .problem import Problem

class Problem1572(Problem):
    def test(self):
        nums = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]

        expected = 25

        result = self.diagonalSum(nums)

        print(result)

        return result == expected

    def diagonalSum(self, mat):
        size = len(mat)
        sum = 0

        for i in range(size):
            sum += mat[i][i]
            sum += mat[i][size - i - 1]

        if size % 2 == 1:
            sum -= mat[size // 2][size // 2]

        return sum