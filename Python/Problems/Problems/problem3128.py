from .problem import Problem
import math


class Problem3128(Problem):
    def test(self):
        grid = [[0, 1, 0], [0, 1, 1], [0, 1, 0]]

        expected = 2

        result = self.numberOfRightTriangles(grid)

        print(result)

        return expected == result

    def numberOfRightTriangles(self, grid):
        n = len(grid)
        m = len(grid[0])
        rows = [0 for _ in range(n)]
        cols = [0 for _ in range(m)]

        for i in range(n):
            for j in range(m):
                if grid[i][j] == 1:
                    rows[i] += 1
                    cols[j] +=1

        result = 0
        for i in range(n):
            for j in range(m):
                if grid[i][j] != 0 and rows[i] > 1 and cols[j] > 1:
                    result += (rows[i] - 1) * (cols[j] - 1)


        return result