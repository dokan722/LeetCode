from utils import print1DArray, print2DArray
from typing import List
from collections import Counter

from .problem import Problem


class Problem3090(Problem):
    def test(self) -> bool:
        s = "bcbbbcba"

        expected = 4

        result = self.maximumLengthSubstring(s)

        print(result)

        return result == expected

    def maximumLengthSubstring(self, s: str) -> int:
        n = len(s)
        counts = [0] * 26
        j = 0
        result = 0
        for i in range(n):
            counts[ord(s[i]) - ord('a')] += 1
            if counts[ord(s[i]) - ord('a')] == 3:
                result = max(i - j, result)
                while counts[ord(s[i]) - ord('a')] == 3:
                    counts[ord(s[j]) - ord('a')] -= 1
                    j += 1

        return max(n - j, result)