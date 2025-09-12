from typing import List

from .problem import Problem


class Problem3227(Problem):
    def test(self) -> bool:
        s = "leetcoder"

        expected = True

        result = self.doesAliceWin(s)

        return expected == result

    def doesAliceWin(self, s: str) -> bool:
        for c in s:
            if c == 'a' or c == 'e' or c == 'i' or c == 'o' or c == 'u':
                return True

        return False