from typing import List

from .problem import Problem


class Problem1790(Problem):
    def test(self) -> bool:
        s1 = "bank"
        s2 = "kanb"

        expected = True

        result = self.areAlmostEqual(s1, s2)

        return expected == result

    def areAlmostEqual(self, s1: str, s2: str) -> bool:
        n = len(s1)
        diffs = []
        for i in range(n):
            if s1[i] != s2[i]:
                if len(diffs) == 2:
                    return False
                diffs.append(i)


        return not diffs or (len(diffs) == 2 and s1[diffs[0]] == s2[diffs[1]] and s1[diffs[1]] == s2[diffs[0]])