import sys
from typing import List, Dict

from .problem import Problem


class Problem3197(Problem):
    def test(self) -> bool:
        grid = [[1, 0, 1], [1, 1, 1]]

        expected = 5

        result = self.minimumSum(grid)

        print(result)

        return expected == result

    def minimumSum(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        result = sys.maxsize
        for i in range(n - 1):
            for j in range(m - 1):
                result = min(result, self.minimumArea(grid, 0, i, 0, j) + self.minimumArea(grid, 0, i, j + 1, m - 1) + self.minimumArea(grid, i + 1, n - 1, 0, m - 1))
                result = min(result, self.minimumArea(grid, 0, i, j + 1, m - 1) + self.minimumArea(grid, i + 1, n - 1, j + 1, m - 1) + self.minimumArea(grid, 0, n - 1, 0, j))
                result = min(result, self.minimumArea(grid, i + 1, n - 1, j + 1, m - 1) + self.minimumArea(grid, i + 1, n - 1, 0, j) + self.minimumArea(grid, 0, i, 0, m - 1))
                result = min(result, self.minimumArea(grid, i + 1, n - 1, 0, j) + self.minimumArea(grid, 0, i, 0, j) + self.minimumArea(grid, 0, n - 1, j + 1, m - 1))

        for i in range(n - 2):
            for j in range(i + 1, n - 1):
                result = min(result, self.minimumArea(grid, 0, i, 0, m - 1) + self.minimumArea(grid, i + 1, j, 0, m - 1) + self.minimumArea(grid, j + 1, n - 1, 0, m - 1))

        for i in range(m - 2):
            for j in range(i + 1, m - 1):
                result = min(result, self.minimumArea(grid, 0, n - 1, 0, i) + self.minimumArea(grid, 0, n - 1, i + 1, j) + self.minimumArea(grid, 0, n - 1, j + 1, m - 1))

        return result

    def minimumArea(self, grid: List[List[int]], topB: int, botB: int, leftB: int, rightB: int) -> int:
        top = 0
        found = False
        for i in range(topB, botB + 1):
            for j in range(leftB, rightB + 1):
                if grid[i][j] == 1:
                    top = i
                    found = True
                    break
            if found:
                break
        if not found:
            return sys.maxsize // 3
        bot = 0
        found = False
        for i in range(botB, topB - 1, -1):
            for j in range(leftB, rightB + 1):
                if grid[i][j] == 1:
                    bot = i
                    found = True
                    break
            if found:
                break
        left = 0
        found = False
        for i in range(leftB, rightB + 1):
            for j in range(topB, botB + 1):
                if grid[j][i] == 1:
                    left = i
                    found = True
                    break
            if found:
                break
        right = 0
        found = False
        for i in range(rightB, leftB - 1, -1):
            for j in range(topB, botB + 1):
                if grid[j][i] == 1:
                    right = i
                    found = True
                    break
            if found:
                break

        return (right - left + 1) * (bot - top + 1)