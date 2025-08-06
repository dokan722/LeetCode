from typing import List

from .problem import Problem


class Problem1051(Problem):
    def test(self) -> bool:
        heights = [1, 1, 4, 2, 1, 3]

        expected = 3

        result = self.heightChecker(heights)

        print(result)

        return expected == result

    def heightChecker(self, heights: List[int]) -> int:
        sorted = list(heights)
        sorted.sort()
        result = 0
        for i in range(len(heights)):
            if heights[i] != sorted[i]:
                result += 1

        return result