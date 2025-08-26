from typing import List

from .problem import Problem


class Problem3000(Problem):
    def test(self) -> bool:
        dimensions = [[9, 3], [8, 6]]

        expected = 48

        result = self.areaOfMaxDiagonal(dimensions)

        print(result)

        return expected == result

    def areaOfMaxDiagonal(self, dimensions: List[List[int]]) -> int:
        maxDia = 0
        maxArea = 0
        for i in range(len(dimensions)):
            dia = dimensions[i][0] ** 2 + dimensions[i][1] ** 2
            if dia > maxDia:
                maxDia = dia
                maxArea = dimensions[i][0] * dimensions[i][1]
            elif dia == maxDia:
                maxArea = max(maxArea, dimensions[i][0] * dimensions[i][1])

        return maxArea