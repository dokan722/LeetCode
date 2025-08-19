from typing import List, Dict

from .problem import Problem


class Problem1647(Problem):
    def test(self) -> bool:
        s = "aaabbbcc"

        expected = 2

        result = self.minDeletions(s)

        print(result)

        return expected == result

    def minDeletions(self, s: str) -> int:
        counts = [0] * 26
        for c in s:
            counts[ord(c) - ord('a')] += 1

        countsCounts = dict()
        usedCounts = set()
        for i in range(26):
            if counts[i] == 0:
                continue
            usedCounts.add(counts[i])
            if counts[i] in countsCounts:
                countsCounts[counts[i]] += 1
            else:
                countsCounts[counts[i]] = 1

        result = 0

        for key, value in countsCounts.items():
            if value > 1:
                smaller = key
                while smaller >= 0 and smaller in usedCounts:
                    smaller -= 1
                for i in range(value - 1):
                    if smaller != 0:
                        usedCounts.add(smaller)
                    result += key - smaller
                    while smaller >= 0 and smaller in usedCounts:
                        smaller -= 1

        return result