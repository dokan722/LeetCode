import sys
from typing import List

from .problem import Problem

class Problem1014(Problem):
    def test(self) -> bool:
        values = [8, 1, 5, 2, 6]

        expected = 11

        result = self.maxScoreSightseeingPair(values)

        print(result)

        return expected == result

    def maxScoreSightseeingPair(self, values: List[int]) -> int:
        maxPrev = 0
        result = -sys.maxsize
        for i in range(1, len(values)):
            dist = i - maxPrev
            value = values[i] + values[maxPrev] - dist
            if value > result:
                result = value
            if values[maxPrev] - dist < values[i]:
                maxPrev = i

        return result