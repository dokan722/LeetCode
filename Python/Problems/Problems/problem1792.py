import heapq
from typing import List

from .problem import Problem


class Problem1792(Problem):
    def test(self) -> bool:
        classes = [[583, 868], [783, 822], [65, 262], [121, 508], [461, 780], [484, 668]]
        extraStudents = 8

        expected = 0.57472

        result = self.maxAverageRatio(classes, extraStudents)

        print(result)

        return abs(expected - result) < 1e-5

    def maxAverageRatio(self, classes: List[List[int]], extraStudents: int) -> float:
        n = len(classes)
        profits = []
        for i in range(n):
            heapq.heappush(profits, (-((classes[i][0] + 1) / (classes[i][1] + 1) - classes[i][0] / classes[i][1]), i))
        for i in range(extraStudents):
            best = heapq.heappop(profits)
            classes[best[1]][0] += 1
            classes[best[1]][1] += 1
            heapq.heappush(profits, (-((classes[best[1]][0] + 1) / (classes[best[1]][1] + 1) - classes[best[1]][0] / classes[best[1]][1]), best[1]))

        result = 0.0
        for i in range(n):
            result += classes[i][0] / classes[i][1]

        return result / n