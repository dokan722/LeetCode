from typing import List

from .problem import Problem


class Problem3325(Problem):
    def test(self) -> bool:
        s = "abacb"
        k = 2

        expected = 4

        result = self.numberOfSubstrings(s, k)

        print(result)

        return expected == result

    def numberOfSubstrings(self, s: str, k: int) -> int:
        n = len(s)
        i = -1
        j = -1
        result = 0
        maxLetter = 0
        counts = [0] * 26
        while i < n - 1:
            while i < n - 1 and counts[maxLetter] < k:
                i += 1
                counts[ord(s[i]) - ord('a')] += 1
                if counts[ord(s[i]) - ord('a')] > counts[maxLetter]:
                    maxLetter = ord(s[i]) - ord('a')

            while j < n - 1 and counts[maxLetter] >= k:
                result += (n - i)
                j += 1
                counts[ord(s[j]) - ord('a')] -= 1

        return result