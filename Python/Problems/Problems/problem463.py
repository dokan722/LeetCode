from .problem import Problem

class Problem463(Problem):
    def test(self):
        grid = [[0, 1, 0, 0], [1, 1, 1, 0], [0, 1, 0, 0], [1, 1, 0, 0]]

        expected = 16

        result = self.islandPerimeter(grid)

        return expected == result

    def islandPerimeter(self, grid):
        result = 0
        for i in range(len(grid)):
            for j in range(len(grid[0])):
                result += self.checkCell(i, j, grid)

        return result

    def checkCell(self, i, j, grid):
        if grid[i][j] == 0:
            return 0
        edges = 0
        if i == 0 or grid[i - 1][j] == 0:
            edges += 1
        if i == len(grid) - 1 or grid[i + 1][j] == 0:
            edges += 1
        if j == 0 or grid[i][j - 1] == 0:
            edges += 1
        if j == len(grid[0]) - 1 or grid[i][j + 1] == 0:
            edges += 1
        return edges