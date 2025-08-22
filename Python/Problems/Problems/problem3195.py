from typing import List, Dict

from .problem import Problem


class Problem3195(Problem):
    def test(self) -> bool:
        grid = [[0, 1, 0], [1, 0, 1]]

        expected = 6

        result = self.minimumArea(grid)

        print(result)

        return result == expected

    def minimumArea(self, grid: List[List[int]]) -> int:
        n = len(grid)
        m = len(grid[0])
        top = 0
        found = False
        for i in range(n):
            for j in range(m):
                if grid[i][j] == 1:
                    top = i
                    found = True
                    break
            if found:
                break
        bot = 0
        found = False
        for i in range(n - 1, -1, -1):
            for j in range(m):
                if grid[i][j] == 1:
                    bot = i
                    found = True
                    break
            if found:
                break
        left = 0
        found = False
        for i in range(m):
            for j in range(n):
                if grid[j][i] == 1:
                    left = i
                    found = True
                    break
            if found:
                break
        right = 0
        found = False
        for i in range(m - 1, -1, -1):
            for j in range(n):
                if grid[j][i] == 1:
                    right = i
                    found = True
                    break
            if found:
                break

        return (right - left + 1) * (bot - top + 1)
