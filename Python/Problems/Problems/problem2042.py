from typing import List

from .problem import Problem

class Problem2042(Problem):
    def test(self) -> bool:
        s = "1 box has 3 blue 4 red 6 green and 12 yellow marbles"

        expected = True

        result = self.areNumbersAscending(s)

        return expected == result

    def areNumbersAscending(self, s: str) -> bool:
        n = len(s)
        prev = -1

        i = 0
        while i < n:
            if s[i].isdigit():
                end = i
                while end < n and s[end].isdigit():
                    end += 1
                num = int(s[i:end])
                if num <= prev:
                    return False

                i = end
                prev = num
            i += 1

        return True