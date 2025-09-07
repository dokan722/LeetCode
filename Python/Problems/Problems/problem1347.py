from typing import List

from .problem import Problem


class Problem1347(Problem):
    def test(self) -> bool:
        s = "leetcode"
        t = "practice"

        expected = 5

        result = self.minSteps(s, t)

        print(result)

        return expected == result

    def minSteps(self, s: str, t: str) -> int:
        counts = [0] * 26
        for i in range(len(s)):
            counts[ord(s[i]) - ord('a')] += 1
            counts[ord(t[i]) - ord('a')] -= 1
        result = 0
        for count in counts:
            if count > 0:
                result += count

        return result