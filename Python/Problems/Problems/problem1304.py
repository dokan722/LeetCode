from typing import List

from .problem import Problem


class Problem1304(Problem):
    def test(self) -> bool:
        n = 5

        result = self.sumZero(n)

        return sum(result) == 0

    def sumZero(self, n: int) -> List[int]:
        result = []
        result.append((n * (n - 1)) / 2)
        for i in range(1,n):
            result.append(-i)

        return result