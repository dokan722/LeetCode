from typing import List, Dict

from .problem import Problem


class Problem837(Problem):
    def test(self) -> bool:
        n = 21
        k = 17
        maxPts = 10

        expected = 0.73278

        result = self.new21Game(n, k, maxPts)

        print(result)

        return abs(expected - result) < 1e-5

    def new21Game(self, n: int, k: int, maxPts: int) -> float:
        probs = [0.0] * (n + 1)
        probs[0] = 1
        sumProb = 0.0
        for i in range(1, n+ 1):
            start = i - maxPts - 1
            if k > start >= 0:
                sumProb -= probs[start] / maxPts
            if i <= k:
                sumProb += probs[i - 1] / maxPts
            probs[i] = sumProb

        result = 0.0
        for i in range(k, n + 1):
            result += probs[i]

        return result