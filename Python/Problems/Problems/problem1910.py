from typing import List

from .problem import Problem


class Problem1910(Problem):
    def test(self) -> bool:
        s = "daabcbaabcbc"
        part = "abc"

        expected = "dab"

        result = self.removeOccurrences(s, part)

        print(result)

        return result == expected

    def removeOccurrences(self, s: str, part: str) -> str:
        index = s.find(part)
        while index != -1:
            s = s[0:index] + s[index + len(part):]
            index = s.find(part)

        return s