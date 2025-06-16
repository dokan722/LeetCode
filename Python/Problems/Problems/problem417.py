from .problem import Problem

class Problem417(Problem):
    def test(self):
        h = [[1, 2, 2, 3, 5], [3, 2, 3, 4, 4], [2, 4, 5, 3, 1], [6, 7, 1, 4, 5], [5, 1, 1, 2, 4]]

        expected = [[0, 4], [1, 3], [1, 4], [2, 2], [3, 0], [3, 1], [4, 0]]

        result = self.pacificAtlantic(h)

        if len(result) != len(expected):
            return False

        for cell in expected:
            if cell not in result:
                return False

        return True

    def pacificAtlantic(self, heights):
        m = len(heights)
        n = len(heights[0])
        pacificCoverage = [[False for _ in range(n)] for _ in range(m)]
        atlanticCoverage = [[False for _ in range(n)] for _ in range(m)]
        result = []

        for i in range(m):
            self.dfsCover(i, 0, heights, pacificCoverage)
        for i in range(n):
            self.dfsCover(0, i, heights, pacificCoverage)
        for i in range(m):
            self.dfsCover(i, n - 1, heights, atlanticCoverage)
        for i in range(n):
            self.dfsCover(m - 1, i, heights, atlanticCoverage)

        for i in range(m):
            for j in range(n):
                if pacificCoverage[i][j] and atlanticCoverage[i][j]:
                    result += [[i, j]]

        return result

    def dfsCover(self, i, j, heights, coverage):
        if coverage[i][j]:
            return
        coverage[i][j] = True

        if i - 1 >= 0 and heights[i][j] <= heights[i - 1][j]:
            self.dfsCover(i - 1, j, heights, coverage)

        if j - 1 >= 0 and heights[i][j] <= heights[i][j - 1]:
            self.dfsCover(i, j - 1, heights, coverage)

        if i + 1 < len(coverage) and heights[i][j] <= heights[i + 1][j]:
            self.dfsCover(i + 1, j, heights, coverage)

        if j + 1 < len(coverage[0]) and heights[i][j] <= heights[i][j + 1]:
            self.dfsCover(i, j + 1, heights, coverage)