
from typing import List

from .problem import Problem


class Problem118(Problem):
    def test(self) -> bool:
        n = 5

        expected = [[1], [1, 1], [1, 2, 1], [1, 3, 3, 1], [1, 4, 6, 4, 1]]

        result = self.generate(n)

        return expected == result

    def generate(self, numRows: int) -> List[List[int]]:
        result = []
        prev = [1]
        result.append(prev)
        for i in range(1, numRows):
            row = [1]
            for j in range(len(prev) - 1):
                row.append(prev[j] + prev[j + 1])
            row.append(1)
            result.append(row)
            prev = row

        return result