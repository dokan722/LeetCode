from typing import List

from .problem import Problem


class Problem1605(Problem):
    def test(self) -> bool:
        rowSum = [3, 8]
        colSum = [4, 7]

        expected = [[3, 0], [1, 7]]

        result = self.restoreMatrix(rowSum, colSum)

        return expected == result

    def restoreMatrix(self, rowSum: List[int], colSum: List[int]) -> List[List[int]]:
        n = len(rowSum)
        m = len(colSum)
        result = []
        for i in range(n):
            result.append([0] * m)
        i = 0
        j = 0

        while i < n and j < m:
            value = min(rowSum[i], colSum[j])
            result[i][j] = value
            rowSum[i] -= value
            colSum[j] -= value
            if rowSum[i] == 0:
                i += 1
            if colSum[j] == 0:
                j += 1

        return result