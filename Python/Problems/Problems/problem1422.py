from typing import List, Dict

from .problem import Problem


class Problem1422(Problem):
    def test(self) -> bool:
        s = "1111"

        expected = 3

        result = self.maxScore(s)

        print(result)

        return result == expected

    def maxScore(self, s: str) -> int:
        ones = 0
        for c in s[1:]:
            if c == '1':
                ones += 1

        zeros = 0
        result = ones
        if s[0] == '1':
            ones += 1
        for c in s[:-1]:
            if c == '1':
                ones -= 1
            else:
                zeros += 1
            if zeros + ones > result:
                result = zeros + ones

        return result