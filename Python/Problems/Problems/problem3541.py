from typing import List
from collections import Counter
from .problem import Problem


class Problem3541(Problem):
    def test(self) -> bool:
        s = "successes"

        expected = 6

        result = self.maxFreqSum(s)

        print(result)

        return expected == result

    def maxFreqSum(self, s: str) -> int:
        counts = dict(Counter(s))

        maxVow = 0
        maxCons = 0
        for letter in counts:
            if letter == 'a' or letter == 'e' or letter == 'i' or letter == 'o' or letter == 'u':
                if counts[letter] > maxVow:
                    maxVow = counts[letter]
            else:
                if counts[letter] > maxCons:
                    maxCons = counts[letter]

        return maxVow + maxCons