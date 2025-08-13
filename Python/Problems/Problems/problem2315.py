from typing import List, Dict

from .problem import Problem


class Problem2315(Problem):
    def test(self) -> bool:
        s = "l|*e*et|c**o|*de|"

        expected = 2

        result = self.countAsterisks(s)

        print(result)

        return result == expected

    def countAsterisks(self, s: str) -> int:
        result = 0
        count = 0
        inside = False
        for c in s:
            if c == '*':
                count += 1
            elif c == '|':
                if not inside:
                    result += count
                count = 0
                inside = not inside

        result += count

        return result