from typing import List

from .problem import Problem

turns = {
    (1, 1): (1, -1),
    (1, -1): (-1, -1),
    (-1, -1): (-1, 1),
    (-1, 1): (1, 1),
}


class Problem3459(Problem):
    def test(self) -> bool:
        grid = [[2, 2, 2, 2, 2], [2, 0, 2, 2, 0], [2, 0, 1, 1, 0], [1, 0, 2, 2, 2], [2, 0, 0, 2, 2]]

        expected = 4

        result = self.lenOfVDiagonal(grid)

        print(result)

        return expected == result

    def lenOfVDiagonal(self, grid: List[List[int]]) -> int:
        result = 0
        n = len(grid)
        m = len(grid[0])
        for dir in turns.keys():
            dpWithTurn = []
            dpWithoutTurn = []
            for i in range(n):
                dpWithTurn.append([-1] * m)
                dpWithoutTurn.append([-1] * m)

            for i in range(n):
                for j in range(m):
                    if grid[i][j] == 1:
                        result = max(result, 1 + self.dfs(grid, dpWithTurn, dpWithoutTurn, n, m, i + dir[0], j + dir[1], dir[0], dir[1], 0, True))

        return result

    def dfs(self, grid: List[List[int]],dpWithTurn: List[List[int]], dpNoTurn: List[List[int]], n: int, m: int, x: int, y: int, ver: int, hor: int, prev: int, haveMove: bool) -> int:
        if x < 0 or x >= n or y < 0 or y >= m or grid[x][y] == 1 or prev == grid[x][y]:
            return 0
        if haveMove and dpWithTurn[x][y] != -1:
            return dpWithTurn[x][y]
        if not haveMove and dpNoTurn[x][y] != -1:
            return dpNoTurn[x][y]

        notTurn = 1 + self.dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], haveMove)
        if not haveMove:
            dpNoTurn[x][y] = notTurn
            return dpNoTurn[x][y]

        (ver, hor) = turns[(ver, hor)]
        turn = 1 + self.dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], False)
        dpWithTurn[x][y] = turn

        return max(notTurn, turn)