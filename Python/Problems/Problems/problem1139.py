from typing import List

from .problem import Problem


class Problem1139(Problem):
    def test(self) -> bool:
        grid = [[1, 1, 1], [1, 0, 1], [1, 1, 1]]

        expected = 9

        result = self.largest1BorderedSquare(grid)

        print(result)

        return expected == result

    def largest1BorderedSquare(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        horizontal = []
        vertical = []
        for i in range(n):
            horizontal.append([0] * m)
            vertical.append([0] * m)
        for i in range(n):
            for j in range(m):
                if j == 0:
                    horizontal[i][j] = grid[i][j]
                else:
                    horizontal[i][j] = horizontal[i][j - 1] + 1 if grid[i][j] == 1 else 0
                if i == 0:
                    vertical[i][j] = grid[i][j]
                else:
                    vertical[i][j] = vertical[i - 1][j] + 1 if grid[i][j] == 1 else 0

        result = 0
        for i in range(n):
            for j in range(m):
                maxSide = min(vertical[i][j], horizontal[i][j])
                if maxSide > result:
                    for k in range(maxSide, result, -1):
                        if vertical[i][j - k + 1] >= k and horizontal[i - k + 1][j] >= k:
                            result = k
                            break

        return result * result