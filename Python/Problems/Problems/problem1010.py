from typing import List

from .problem import Problem


class Problem1010(Problem):
    def test(self) -> bool:
        time = [30, 20, 150, 100, 40]

        expected = 3

        result = self.numPairsDivisibleBy60(time)

        print(result)

        return result == expected

    def numPairsDivisibleBy60(self, time: List[int]) -> int:
        n = len(time)
        rests = [0] * 60
        result = 0

        for i in range(n):
            rest = time[i] % 60
            expected = (60 - rest) % 60
            result += rests[expected]
            rests[rest] += 1

        return result