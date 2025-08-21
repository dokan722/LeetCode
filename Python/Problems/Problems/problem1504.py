from typing import List, Dict

from .problem import Problem


class Problem1504(Problem):
    def test(self) -> bool:
        mat = [[1, 0, 1], [1, 1, 0], [1, 1, 0]]

        expected = 13

        result = self.numSubmat(mat)

        print(result)

        return expected == result

    def numSubmat(self, mat: List[List[int]]) -> int:
        n = len(mat)
        m = len(mat[0])
        columns = [0] * m

        result = 0
        for i in range(n):
            rectangles = [0] * m
            prevColumns = []
            for j in range(m):
                columns[j] = 0 if mat[i][j] == 0 else columns[j] + 1
                while prevColumns and columns[prevColumns[-1]] >= columns[j]:
                    prevColumns.pop()
                if prevColumns:
                    smaller = prevColumns[-1]
                    rectangles[j] = rectangles[smaller] + columns[j] * (j - smaller)
                else:
                    rectangles[j] = (j + 1) * columns[j]
                prevColumns.append(j)
                result += rectangles[j]

        return result