from typing import List

from .problem import Problem


class Problem3446(Problem):
    def test(self) -> bool:
        grid = [[1, 7, 3], [9, 8, 2], [4, 5, 6]]

        expected = [[8, 2, 3], [9, 6, 7], [4, 5, 1]]

        result = self.sortMatrix(grid)

        return expected == result

    def sortMatrix(self, grid: List[List[int]]) -> List[List[int]]:
        n = len(grid)

        for i in range(n):
            helper = []
            for j in range(i + 1):
                helper.append(grid[n - 1 - i + j][j])
            helper.sort(reverse=True)
            for j in range(i + 1):
                grid[n - 1 - i + j][j] = helper[j]

        for i in range(n - 1):
            helper = []
            for j in range(i + 1):
                helper.append(grid[j][n - 1 - i + j])
            helper.sort()
            for j in range(i + 1):
                grid[j][n - 1 - i + j] = helper[j]

        return grid