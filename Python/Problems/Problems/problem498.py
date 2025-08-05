from typing import List

from .problem import Problem


class Problem498(Problem):
    def test(self) -> bool:
        mat = [[1,2,3],[4,5,6],[7,8,9]]

        expected = [1, 2, 4, 7, 5, 3, 6, 8, 9]

        result = self.findDiagonalOrder(mat)

        return result == expected

    def findDiagonalOrder(self, mat: List[List[int]]) -> List[int]:
        n = len(mat)
        m = len(mat[0])
        cap = max(n, m)
        result = []

        x = 0
        y = 0
        for i in range(2 * cap - 1):
            if i % 2 == 1:
                y = min(i, cap - 1)
                x = max(0, i - cap + 1)
                while x < cap and y >= 0:
                    if x < n and y < m:
                        result.append(mat[x][y]);
                    x += 1
                    y -= 1
            else:
                x = min(i, cap - 1)
                y = max(0, i - cap + 1)
                while y < cap and x >= 0:
                    if x < n and y < m:
                        result.append(mat[x][y])
                    y += 1
                    x -= 1

        return result