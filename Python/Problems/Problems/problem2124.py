from typing import List, Dict

from .problem import Problem


class Problem2124(Problem):
    def test(self) -> bool:
        s = "aaabbb"

        expected = True

        result = self.checkString(s)

        return expected == result

    def checkString(self, s: str) -> bool:
        bs = s[0] == 'b'
        for c in s:
            if c == 'a' and bs:
                return False
            if c == 'b':
                bs = True

        return True

